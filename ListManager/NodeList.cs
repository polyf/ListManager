namespace ListManager
{
    public class NodeList
    {
        public Node? Head { get; set; }
        public Node? Tail { get; set; }
        public int Size;

        public NodeList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        public NodeList Init ()
        {
            NodeList list = new NodeList();
            return list;
        }
        
        public bool IsListEmpty()
        {
            return Head != null && Tail != null;
        }


        public void Add(int value)
        {
            
        }

    }
}
