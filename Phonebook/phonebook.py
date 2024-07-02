

def work_with_phonebook():                  # Блок работы с основным меню
    while True:
        choice =  show_menu()
        
        if choice == 1:
            show_phonebook(phonebook)
        elif choice == 2:
            contact_list = read_txt(phonebook)
            find_contact(contact_list)
        elif choice == 3:
            change_contact(phonebook)
        elif choice == 4:
            add_new_abonent(phonebook)
        elif choice == 5:
            delete_contact(phonebook)
        elif choice == 6:
            contact_list = read_file_to_list(phonebook)
            write_txt(phonebook, contact_list)
        elif choice == 7:
            print("Закончить работу")
            break 
        else:
            print("Неправильно выбрана команда")
            print()
            continue


def show_menu():
    print("\nВыберите необходимое действие:\n"
          "1. Отобразить весь справочник\n"
          "2. Найти абонента по фамилии или по номеру телефона\n"
          "3. Изменить данные абонента\n"
          "4. Добавить абонента в справочник\n"
          "5. Удалить абонента из справочника\n"
          "6. Сохранить данные в файл\n"
          "7. Закончить работу")
    choice = int(input())
    return choice


def show_phonebook(file_name):              # Формирование вывода телефонной книги на экран
    print_contacts(read_txt(file_name))
    print()

def read_txt(file_name):                    # Формирование кортежа для вывода телефонной книги (мне формат не нравится, но подумать не успеваю)

    with open(file_name,'r',encoding='utf-8') as file:
        phone_book = []
        fields = ['Фамилия', 'Имя', 'Телефон', 'Описание']
        for line in file:
            record = dict(zip(fields, line.split(',')))
            line = {key: value.strip() for key, value in record.items()}
            if line["Фамилия"].strip() != "":
                phone_book.append(line)
    return phone_book

def print_contacts(phone_book: list):       # Вывод на экран телефонной книги
    for contact in phone_book: 
        for key, value in contact.items():
            print(f"{key}: {value:12}", end='')
        print()

def find_contact(contact_list):             # Поиск контакта и вывод на экран
    search_field, search_value = search_parameters()
    search_value_dict = {1: "Фамилия", 2: "Имя", 3: "Номер телефона"}
    found_contacts = [] 
    for contact in contact_list:
        if contact[search_value_dict[search_field]] == search_value:
            found_contacts.append(contact)
    if len(found_contacts) == 0:
        print("Контакт не найден!")
    else:
        print_contacts(found_contacts)
    print()
            
def search_parameters():                    # Выбор параметра ля поиска контакта
    print("По какому полю выполнить поиск?\n1 - по фамилии\n2 - по имени\n3 - по номеру телефона\n")
    search_field = int(input())
    print()
    search_value = None
    if search_field == 1:
        search_value = input("Введите фамилию для поиска: ")
        print()
    elif search_field == 2:
        search_value = input("Введите имя для поиска: ")
        print()
    elif search_field == 3:
        search_value = input("Введите номер для поиска: ")
        print()
    return search_field, search_value

def change_contact(file_name):              # Изменение контакта
    contact_list = read_file_to_list(file_name)
    number_to_change = search_to_modify(contact_list)
    contact_list.remove(number_to_change)
    # contact_list.remove(filter(number_to_change != 0))    (Хотела исключить ошибку программы, в случае, если контакт не найден, но не разобралась пока)
    print("Какое поле вы хотите изменить?\n1 - Фамилия\n2 - Имя\n3 - Номер телефона\n4 - Описание")
    field = int(input())
    if field == 1:
        number_to_change[0] = input("Введите фамилию: ")
    elif field == 2:
        number_to_change[1] = input("Введите имя: ")
    elif field == 3:
        number_to_change[2] = input("Введите номер телефона: ")
    elif field == 4:
        number_to_change[3] = input("Введите описание: ")
    contact_list.append(number_to_change)
    write_txt(file_name, contact_list)

def search_to_modify(contact_list):         # Замена данных контакта
    search_field, search_value = search_parameters()
    search_result = []
    for contact in contact_list:
        if contact[search_field - 1] == search_value:
            search_result.append(contact)
    if len(search_result) == 1:
        return search_result[0]
    elif len(search_result) > 1:
        print("Найдено несколько контактов")
        for i in range(len(search_result)):
            print(f"{i + 1} - {search_result[i]}")
        num_count = int(input("Выберите номер контакта, который нужно изменить/удалить: "))
        return search_result[num_count - 1]
    else:
        print("Контакт не найден")
        print()

def add_new_abonent(file_name):             # Добавение нового контакта
    contact_list = read_file_to_list(file_name)
    new_line = []
    new_line.append(input("Введите фамилию: "))
    new_line.append(input("Введите имя: "))
    new_line.append(input("Введите номер телефона: "))
    new_line.append(input("Введите описание: "))
    contact_list.append(new_line)
    write_txt(file_name, contact_list)

def delete_contact(file_name):              # Удаление контакта
    contact_list = read_file_to_list(file_name)
    number_to_change = search_to_modify(contact_list)
    contact_list.remove(number_to_change)
    write_txt(file_name, contact_list)

def write_txt(file_name, contact_list):     # Сохранение телефонной книги
    # with open(file_name, "r+", encoding="utf-8") as file:     (Этот вариант ме нравился больше, но при обращении из программы сбивалось офрмление тел.книги)
    #     for contact in contact_list:
    #         line = ', '.join(contact)
    #         # line = ', '.join(contact) + "\n"
    #         file.write(line)
    with open(file_name,'r+',encoding='utf-8') as phout:
        for i in range(len(contact_list)):
            s=''
            for v in contact_list[i]:
                s = s + v + ','
            phout.write(f'{s[:-1]}\n')                          # с каждой перезаписью книги увеличивает количество пробеов между строками, не разобралась,
                                                                # как регулярно убирать пустые строки
def read_file_to_list(file_name):           # Подготовка телефонной книги к обработке данных: разбиение на массив строчных данных
    with open(file_name, 'r', encoding='utf-8') as file:
        contact_list = []
        for line in file.readlines():
            contact_list.append(line.split(","))
    return contact_list


phonebook = "phone.txt"
work_with_phonebook()