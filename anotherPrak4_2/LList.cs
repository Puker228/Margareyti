namespace prak4_2;

class LList
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
                Node nNode = new Node();
                nNode.data = value;
                nNode.next = null;

                if (head == null)
                {
                    nNode.prev = null;
                    head = nNode;
                }
                else
                {
                    Node lastNode = head;
                    while (lastNode.next != null)
                    {
                        lastNode = lastNode.next;
                    }

                    lastNode.next = nNode;
                    nNode.prev = lastNode;
                }
            }
        }
        public void AddData(int data)
        {
            Node nNode = new Node();
            nNode.data = data;

            if (head == null)
            {
                head = nNode;
            }
            else
            {
                Node lNode = head;
                while (lNode.next != null)
                {
                    lNode = lNode.next;
                }
                lNode.next = nNode;
                nNode.prev = lNode;
            }
        }
        public void InsertPos(int data, int position)
        {
            Node nNode = new Node();
            nNode.data = data;

            if (position == 1)
            {
                nNode.next = head;
                head.prev = nNode;
                head = nNode;
            }
            else
            {
                Node t = head;
                for (int i = 1; i < position - 1; i++)
                {
                    t = t.next;
                }

                nNode.next = t.next;
                t.next.prev = nNode;
                t.next = nNode;
                nNode.prev = t;
            }
        }
        public void DelData(int position)
        {
            if (position == 1)
            {
                head = head.next;
                head.prev = null;
            }
            else
            {
                Node t = head;
                for (int i = 1; i < position - 1; i++)
                {
                    t = t.next;
                }
                t.next = t.next.next;
                t.next.prev = t;
            }
        }
        public void ReadData()
        {
            Node cur = head;
            while (cur != null)
            {
                Console.Write(cur.data + " ");
                cur = cur.next;
            }
            Console.WriteLine();
        }
    }