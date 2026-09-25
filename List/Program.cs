namespace List
{
    internal class Program
    {
        //односвязный список (без хвоста) 
        public class SLNode
        {
            public int Value;
            public SLNode Next;

            public SLNode(int value)
            {
                Value = value;
            }
        }

        public class SinglyLinkedList
        {
            public SLNode Head;
            private int count = 0;

            public void AddFirst(int item)
            {
                SLNode newNode = new SLNode(item);
                newNode.Next = Head;
                Head = newNode;
                count++;
            }

            public void AddLast(int item)
            {
                SLNode newNode = new SLNode(item);

                if (Head == null)
                {
                    Head = newNode;
                    count++;
                    return;
                }

                SLNode current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                count++;
            }

            public bool RemoveFirst()
            {
                if (Head == null)
                {
                    return false;
                }

                Head = Head.Next;
                count--;
                return true;
            }

            public bool RemoveLast()
            {
                if (Head == null)
                {
                    return false;
                }

                if (Head.Next == null)
                {
                    Head = null;
                    count--;
                    return true;
                }

                SLNode current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                count--;
                return true;
            }

            public bool RemoveValue(int item)
            {
                if (Head == null)
                {
                    return false;
                }

                if (Head.Value == item)
                {
                    Head = Head.Next;
                    count--;
                    return true;
                }

                SLNode current = Head;
                while (current.Next != null && current.Next.Value != item)
                {
                    current = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                    count--;
                    return true;
                }

                return false;
            }

            public void Clear()
            {
                Head = null;
                count = 0;
            }

            public int GetCount()
            {
                return count;
            }
        }

        // односвязный список с хвостом
        public class STNode
        {
            public int Value;
            public STNode Next;

            public STNode(int value)
            {
                Value = value;
            }
        }

        public class SinglyLinkedListWithTail
        {
            public STNode Head;
            public STNode Tail;
            private int count = 0;

            public void AddFirst(int item)
            {
                STNode newNode = new STNode(item);

                if (Head == null)
                {
                    Head = newNode;
                    Tail = newNode;
                }
                else
                {
                    newNode.Next = Head;
                    Head = newNode;
                }
                count++;
            }

            public void AddLast(int item)
            {
                STNode newNode = new STNode(item);

                if (Tail == null)
                {
                    Head = newNode;
                    Tail = newNode;
                }
                else
                {
                    Tail.Next = newNode;
                    Tail = newNode;
                }
                count++;
            }

            public bool RemoveFirst()
            {
                if (Head == null)
                {
                    return false;
                }

                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
                count--;
                return true;
            }

            public bool RemoveLast()
            {
                if (Head == null)
                {
                    return false;
                }

                if (Head == Tail)
                {
                    Head = null;
                    Tail = null;
                    count--;
                    return true;
                }

                STNode current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                Tail = current;
                count--;
                return true;
            }

            public bool RemoveValue(int item)
            {
                if (Head == null)
                {
                    return false;
                }

                if (Head.Value == item)
                {
                    Head = Head.Next;
                    if (Head == null)
                    {
                        Tail = null;
                    }
                    count--;
                    return true;
                }

                STNode current = Head;
                while (current.Next != null && current.Next.Value != item)
                {
                    current = current.Next;
                }

                if (current.Next != null)
                {
                    if (current.Next == Tail)
                    {
                        Tail = current;
                    }
                    current.Next = current.Next.Next;
                    count--;
                    return true;
                }

                return false;
            }

            public void Clear()
            {
                Head = null;
                Tail = null;
                count = 0;
            }

            public int GetCount()
            {
                return count;
            }
        }

        //двусвязный список
        public class DNode
        {
            public int Value;
            public DNode Next;
            public DNode Prev;

            public DNode(int value)
            {
                Value = value;
            }
        }

        public class DoublyLinkedList
        {
            public DNode Head;
            public DNode Tail;
            private int count = 0;

            public void AddFirst(int item)
            {
                DNode newNode = new DNode(item);

                if (Head == null)
                {
                    Head = newNode;
                    Tail = newNode;
                }
                else
                {
                    newNode.Next = Head;
                    Head.Prev = newNode;
                    Head = newNode;
                }
                count++;
            }

            public void AddLast(int item)
            {
                DNode newNode = new DNode(item);

                if (Tail == null)
                {
                    Head = newNode;
                    Tail = newNode;
                }
                else
                {
                    newNode.Prev = Tail;
                    Tail.Next = newNode;
                    Tail = newNode;
                }
                count++;
            }

            public bool RemoveFirst()
            {
                if (Head == null)
                {
                    return false;
                }

                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
                else
                {
                    Head.Prev = null;
                }
                count--;
                return true;
            }

            public bool RemoveLast()
            {
                if (Tail == null)
                {
                    return false;
                }

                Tail = Tail.Prev;
                if (Tail == null)
                {
                    Head = null;
                }
                else
                {
                    Tail.Next = null;
                }
                count--;
                return true;
            }

            public bool RemoveValue(int item)
            {
                DNode current = Head;

                while (current != null)
                {
                    if (current.Value == item)
                    {
                        if (current.Prev != null)
                        {
                            current.Prev.Next = current.Next;
                        }
                        else
                        {
                            Head = current.Next;
                        }

                        if (current.Next != null)
                        {
                            current.Next.Prev = current.Prev;
                        }
                        else
                        {
                            Tail = current.Prev;
                        }

                        count--;
                        return true;
                    }

                    current = current.Next;
                }

                return false;
            }

            public void Clear()
            {
                Head = null;
                Tail = null;
                count = 0;
            }

            public int GetCount()
            {
                return count;
            }
        }

        //Циклический двусвязный список
        public class CDNode
        {
            public int Value;
            public CDNode Next;
            public CDNode Prev;

            public CDNode(int value)
            {
                Value = value;
            }
        }

        public class CircularDoublyLinkedList
        {
            public CDNode Head;
            private int count = 0;

            private void InsertToEmpty(CDNode node)
            {
                node.Next = node;
                node.Prev = node;
                Head = node;
                count++;
            }

            public void AddFirst(int item)
            {
                CDNode newNode = new CDNode(item);

                if (Head == null)
                {
                    InsertToEmpty(newNode);
                    return;
                }

                CDNode tail = Head.Prev;

                newNode.Next = Head;
                newNode.Prev = tail;
                tail.Next = newNode;
                Head.Prev = newNode;

                Head = newNode;
                count++;
            }

            public void AddLast(int item)
            {
                CDNode newNode = new CDNode(item);

                if (Head == null)
                {
                    InsertToEmpty(newNode);
                    return;
                }

                CDNode tail = Head.Prev;

                newNode.Next = Head;
                newNode.Prev = tail;
                tail.Next = newNode;
                Head.Prev = newNode;

                count++;
            }

            public bool RemoveFirst()
            {
                if (Head == null)
                {
                    return false;
                }

                if (Head.Next == Head)
                {
                    Head = null;
                    count--;
                    return true;
                }

                CDNode tail = Head.Prev;
                CDNode newHead = Head.Next;

                tail.Next = newHead;
                newHead.Prev = tail;
                Head = newHead;

                count--;
                return true;
            }

            public bool RemoveLast()
            {
                if (Head == null)
                {
                    return false;
                }

                if (Head.Next == Head)
                {
                    Head = null;
                    count--;
                    return true;
                }

                CDNode tail = Head.Prev;
                CDNode newTail = tail.Prev;

                newTail.Next = Head;
                Head.Prev = newTail;

                count--;
                return true;
            }

            public bool RemoveValue(int item)
            {
                if (Head == null)
                {
                    return false;
                }

                CDNode current = Head;

                do
                {
                    if (current.Value == item)
                    {
                        if (current.Next == current)
                        {
                            Head = null;
                        }
                        else
                        {
                            current.Prev.Next = current.Next;
                            current.Next.Prev = current.Prev;

                            if (current == Head)
                            {
                                Head = current.Next;
                            }
                        }

                        count--;
                        return true;
                    }

                    current = current.Next;
                }
                while (current != Head);

                return false;
            }

            public void Clear()
            {
                Head = null;
                count = 0;
            }

            public int GetCount()
            {
                return count;
            }
        }


        static void Main()
        {
            Console.WriteLine("односвязный");
            var list1 = new SinglyLinkedList();

            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            PrintList1(list1, "После AddLast(1,2,3)");

            list1.AddFirst(0);
            PrintList1(list1, "После AddFirst(0)");

            list1.RemoveFirst();
            PrintList1(list1, "После RemoveFirst()");

            list1.RemoveLast();
            PrintList1(list1, "После RemoveLast()");

            list1.AddLast(5);
            list1.AddLast(5);
            bool removed1 = list1.RemoveValue(5);
            PrintList1(list1, "После RemoveValue(5) -> " + removed1);

            Console.WriteLine("GetCount(): " + list1.GetCount());

            list1.Clear();
            PrintList1(list1, "После Clear()");
            Console.WriteLine();

            Console.WriteLine("односвязный с хвостом");
            var list2 = new SinglyLinkedListWithTail();

            list2.AddLast(1);
            list2.AddLast(2);
            list2.AddLast(3);
            PrintList2(list2, "После AddLast(1,2,3)");

            list2.AddFirst(0);
            PrintList2(list2, "После AddFirst(0)");

            list2.RemoveFirst();
            PrintList2(list2, "После RemoveFirst()");

            list2.RemoveLast();
            PrintList2(list2, "После RemoveLast()");

            list2.AddLast(5);
            list2.AddLast(5);
            bool removed2 = list2.RemoveValue(5);
            PrintList2(list2, "После RemoveValue(5) -> " + removed2);

            Console.WriteLine("GetCount(): " + list2.GetCount());

            list2.Clear();
            PrintList2(list2, "После Clear()");
            Console.WriteLine();

            Console.WriteLine("двусвязный");
            var list3 = new DoublyLinkedList();

            list3.AddLast(1);
            list3.AddLast(2);
            list3.AddLast(3);
            PrintList3(list3, "После AddLast(1,2,3)");

            list3.AddFirst(0);
            PrintList3(list3, "После AddFirst(0)");

            list3.RemoveFirst();
            PrintList3(list3, "После RemoveFirst()");

            list3.RemoveLast();
            PrintList3(list3, "После RemoveLast()");

            list3.AddLast(5);
            list3.AddLast(5);
            bool removed3 = list3.RemoveValue(5);
            PrintList3(list3, "После RemoveValue(5) -> " + removed3);

            Console.WriteLine("GetCount(): " + list3.GetCount());

            list3.Clear();
            PrintList3(list3, "После Clear()");
            Console.WriteLine();

            Console.WriteLine("циклический двусвязный");
            var list4 = new CircularDoublyLinkedList();

            list4.AddLast(1);
            list4.AddLast(2);
            list4.AddLast(3);
            PrintList4(list4, "После AddLast(1,2,3)");

            list4.AddFirst(0);
            PrintList4(list4, "После AddFirst(0)");

            list4.RemoveFirst();
            PrintList4(list4, "После RemoveFirst()");

            list4.RemoveLast();
            PrintList4(list4, "После RemoveLast()");

            list4.AddLast(5);
            list4.AddLast(5);
            bool removed4 = list4.RemoveValue(5);
            PrintList4(list4, "После RemoveValue(5) -> " + removed4);

            Console.WriteLine("GetCount(): " + list4.GetCount());

            list4.Clear();
            PrintList4(list4, "После Clear()");
        }

            static void PrintList1(SinglyLinkedList list, string label)
            {
                Console.Write(label + ": ");
                SLNode current = list.Head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

            static void PrintList2(SinglyLinkedListWithTail list, string label)
            {
                Console.Write(label + ": ");
                STNode current = list.Head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

            static void PrintList3(DoublyLinkedList list, string label)
            {
                Console.Write(label + ": ");
                DNode current = list.Head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

            static void PrintList4(CircularDoublyLinkedList list, string label)
            {
                Console.Write(label + ": ");

                if (list.Head == null)
                {
                    Console.WriteLine("(пусто)");
                    return;
                }

                CDNode current = list.Head;
                do
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                while (current != list.Head);

                Console.WriteLine();
            }
        }

    }

