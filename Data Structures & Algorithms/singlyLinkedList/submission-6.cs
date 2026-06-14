public class LinkedList {

    private record Node {
        public int Val {get; set; }
        public Node? Next { get; set; }
    }

    private Node? head = null;
    int size = 0;

    public LinkedList() {
        this.head = null;
        this.size = 0;
    }

    public int Get(int index) {
        if(index > this.size - 1 || this.head is null) return -1;
        Node node = this.head;
        int curr = 0;
        while(curr < index) 
        {
            node = node.Next;
            curr++;
        }
        return node.Val;
    }

    public void InsertHead(int val) {

        if(this.head is null) {
            this.head = new Node {Val = val, Next = null };
        } else {
            Node n = new Node {Val = val, Next = this.head };
            this.head = n;
        }
        this.size++;
    }

    public void InsertTail(int val) {

        if (this.head is null) {
            this.head = new Node {Val = val, Next = null };
            this.size++;

            return;
        }
            Node n = this.head;
            while(n.Next is not null)
                n = n.Next;
             
            Node newNode = new Node {Val = val, Next = null };
            n.Next = newNode;
            this.size++;
    }

    public bool Remove(int index) {
        if(index > this.size - 1) return false;

        if(index == 0) {
            this.head = this.head.Next;
            this.size--;
            return true;
        } 
        int i = 0;
        Node n = this.head;
        while(i < index - 1) {
            i++;
            n = n.Next;
        }

        Node prev = n;
        n = prev.Next;
        prev.Next = n.Next;
        n.Next = null;
        this.size--;
        if(size == 0) this.head = null;
        return true;
    }

    public List<int> GetValues() {
        List<int> result = new List<int>();
        if(this.size < 1) return result;
        Node? n = this.head;
        while(n is not null) {
            result.Add(n.Val);
            n = n.Next;
        }
        return result;
    }
}