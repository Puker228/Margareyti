using System;

namespace prak4_2
{
    class Program
    {
        static void Main()
        {
            LinkedList list = null;
            
            while(true)
            {
                Console.WriteLine("1 - Создать список");
                Console.WriteLine("2 - Добавить в конец списка");
                Console.WriteLine("3 - Добавить в список");
                Console.WriteLine("4 - Удалить элемент из списка");
                Console.WriteLine("5 - Вывести список");
                Console.WriteLine("6 - Удалить список");
                Console.WriteLine("7 - Выйти");
                Console.Write("Действие: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        list = new LinkedList();
                        list.AddList();
                        Console.WriteLine("Список создан");
                        break;
                    case "2":
                        Console.Write("Новые данные: ");
                        int data = Convert.ToInt32(Console.ReadLine());
                        list.Addd(data);
                        break;
                    case "3":
                        Console.Write("Новые данные: ");
                        int insertData = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Позиция: ");
                        int position = Convert.ToInt32(Console.ReadLine());
                        list.InsertPosition(insertData, position);
                        break;
                    case "4":
                        Console.Write("Позиция: ");
                        int deletePosition = Convert.ToInt32(Console.ReadLine());
                        list.Del(deletePosition);
                        break;
                    case "5":
                        list.Read();
                        break;
                    case "6":
                        list = null;
                        Console.WriteLine("Список обнулен");
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Нет такого выбора");
                        break;
                }
            } 
        }
    }
    class LinkedList
    {
        private Node head;
        
        
        public void AddList()
        {
            Console.Write("Введите количество элементов: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("\nВведите значение элемента: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Node newNode = new Node();
                newNode.data = value;
                newNode.next = null;

                if (head == null)
                {
                    newNode.previous = null;
                    head = newNode;
                }
                else
                {
                    Node lastNode = head;
                    while (lastNode.next != null)
                    {
                        lastNode = lastNode.next;
                    }
                    lastNode.next = newNode;
                    newNode.previous = lastNode;
                }
            }
        }
        
        public void Addd(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node lastNode = head;
                while (lastNode.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = newNode;
                newNode.previous = lastNode;
            }
        }

        public void InsertPosition(int data, int position)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (position == 1)
            {
                newNode.next = head;
                head.previous = newNode;
                head = newNode;
            }
            else
            {
                Node temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    temp = temp.next;
                }

                newNode.next = temp.next;
                temp.next.previous = newNode;
                temp.next = newNode;
                newNode.previous = temp;
            }
        }

        public void Del(int pos)
        {
            if (pos == 1)
            {
                head = head.next;
                head.previous = null;
            }
            else
            {
                Node temp = head;
                for (int i = 1; i < pos - 1; i++)
                {
                    temp = temp.next;
                }
                temp.next = temp.next.next;
                temp.next.previous = temp;
            }
        }

        public void Read()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
    
    class Node
    {
        public int data;
        public Node previous;
        public Node next;
    }

}