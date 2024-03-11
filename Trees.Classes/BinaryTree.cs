using System.Net;

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
           if (Left != null)
            {
                Left.InOrder(nodeValues);
            }

           nodeValues.Add(Node);

            if (Right != null)
            {
                Right.InOrder(nodeValues);
            }

            
        }

        

        public void PreOrder(List<T> nodeValues)
        {
            nodeValues.Add(Node);

            if (Left != null)
            {
                Left.PreOrder(nodeValues);
            }

            if (Right != null)
            {
                Right.PreOrder(nodeValues);
            }


        }

        public void PostOrder(List<T> nodeValues)
        { 
            if (Left != null)
            {
                Left.PostOrder(nodeValues);
            }

            if (Right != null)
            {
                Right.PostOrder(nodeValues);
            }

            nodeValues.Add(Node);
        }

        private List<BinaryTree<T>> SayHelloToNewNeighbours(HashSet<BinaryTree<T>> cookieLog)
        {
            List<BinaryTree<T>> FriendlyNeighbourList = new List<BinaryTree<T>>();

            if (Left != null)
            {
                if (!cookieLog.Contains(Left))
                {
                    FriendlyNeighbourList.Add(Left);
                }

                
            }

            if (Right != null)
            {
                if (!cookieLog.Contains(Right))
                {
                    FriendlyNeighbourList.Add(Right);
                }
                    
            }

            return FriendlyNeighbourList;
        }

        private bool IsChildFree()
        {
            var result = true;

            result &= this.Left == null && this.Right == null;

            return result;
        }

        public List<T> BreadthFirst()
        {
            List<T> CookieJar = new List<T>();

            HashSet<BinaryTree<T>> WaitIveBeenToThisHouseAlready = new HashSet<BinaryTree<T>>();

            Queue<BinaryTree<T>> eatenCookies = new Queue<BinaryTree<T>>();

            eatenCookies.Enqueue(this);

            while (eatenCookies.Count > 0)
            {
                BinaryTree<T> KnockOnTheDoor = eatenCookies.Dequeue();
                CookieJar.Add(KnockOnTheDoor.Node);

                foreach (BinaryTree<T> friendlyNeighbour in KnockOnTheDoor.SayHelloToNewNeighbours(WaitIveBeenToThisHouseAlready))
                {
                    
                    WaitIveBeenToThisHouseAlready.Add(friendlyNeighbour);
                    eatenCookies.Enqueue(friendlyNeighbour);
                }
            }

            return CookieJar;
        }

        public bool Contains(T node)
        {
            var happiness = false;

            if (Node.Equals(node))
            {
                happiness = true;
            }

            if (Left != null)
            {
                happiness = happiness | Left.Contains(node);
            }

            if (Right != null)
            {
                happiness = happiness | Right.Contains(node);
            }

            return happiness;
        }

        
        public virtual void Add(T newNode)
        {
            int result = newNode.CompareTo(Node);
            
            if (result < 0)
            {
                if (Left != null)
                {
                    Left.Add(newNode);
                } else
                {
                    BinaryTree<T> newThingy = new(newNode);
                    Left = newThingy;
                }
            } else
            {
                if (Right != null)
                {
                    Right.Add(newNode);
                }
                else
                {
                    BinaryTree<T> newThingy = new(newNode);
                    Right = newThingy;
                }
            }
        }


        public void Add(List<T> newNodes)
        {
           foreach (T node in newNodes)
            {
                this.Add(node);
            }
           
        }

        public void Remove(T node)
        {

            List<T> orphans = new List<T>();

            this.PreOrder(orphans);

            if (orphans.Contains(node))
            {
                orphans.Remove(node);
                
            }

            orphans.RemoveAt(0);

            Left = null;
            Right = null;

            this.Add(orphans);

        }
     
    }
}