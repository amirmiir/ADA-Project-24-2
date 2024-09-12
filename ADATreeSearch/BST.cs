using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using QueueADT;

namespace ADATreeSearch
{
    public class BST
    {
        
        private BSTNode root;

        public BST()
        {
            this.root = null;
        }

        /*Método de Insertar un elemento al árbol*/
        public void insert(int e)
        {
            BSTNode p = this.root, prev=null;
            /*Iterando a través del árbol para buscar el lugar que le corresponde
             *
             */
            while (p != null)
            {
                prev = p;
                if(p.GetKey() < e)
                {
                    p = p.right;
                }
                else
                {
                    p = p.left;
                }
            }

            if (root == null)
            {
                root = new BSTNode(e);
            } else if (prev.GetKey() < e)
            {
                prev.right = new BSTNode(e);
            }
            else
            {
                prev.left = new BSTNode(e);
            }
        }

        public void Visit(BSTNode p)
        {
            if(p != null)
            {
                Console.WriteLine(p.GetKey()+" ");
            }
            else
            {
                Console.WriteLine("Nodo no existe.");
            }
        }

        /*Recorrido por Fuerza Bruta*/
        public void BreadthFirstSearch()
        {
            BSTNode p = root;
            LinkedQueueADT<BSTNode> queue = new LinkedQueueADT<BSTNode>();
            if(p != null)
            {
                queue.add(p);
                while (!queue.isEmpty())
                {
                    p = (BSTNode) queue.remove();
                    Visit(p);
                    if(p.left != null)
                    {
                        queue.add(p.left);
                    }
                    if(p.right != null)
                    {
                        queue.add(p.right);
                    }
                }
            }
        }

        public void Preorder()
        {
            Preorder(root);
        }

        public void Preorder(BSTNode p)
        {
            /*Only one case existing for the recursion*/
            if(p != null)
            {
                /*Accomplishing goal for current BSTNode*/
                Visit(p.left);

                /*Starting the recursion for the two children of the current BSTNode*/
                Preorder(p.left);
                Preorder(p.right);
            }
            /*Else Does Nothing*/
        }

        public void Inorder()
        {

        }

        public void Postorder()
        {

        }
    }
}
