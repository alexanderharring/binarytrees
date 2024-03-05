namespace Trees.Classes
{
    public class BinaryTree<T> where T : IComparable<T>, IEquatable<T>
    {     
      
        // Public properties
        public T Node { get; private set; }

        public BinaryTree<T>? Left
        {
            get; protected set;
        }

        public BinaryTree<T>? Right
        {
            get; protected set;
        }

        // Constructor
        public BinaryTree(T node)
        {
            Node = node;
        }

        // Public methods
        public void InOrder(List<T> nodeValues)
        {         
           throw new NotImplementedException();
        }

        public void PreOrder(List<T> nodeValues)
        {
            throw new NotImplementedException();
        }

        public void PostOrder(List<T> nodeValues)
        {
            throw new NotImplementedException();
        }

        public List<T> BreadthFirst()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T node)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(T newNode)
        {
            throw new NotImplementedException();
        }

        public void Add(List<T> newNodes)
        {
           throw new NotImplementedException();
        }

        public void Remove(T node)
        {
            throw new NotImplementedException();
        }
     
    }
}