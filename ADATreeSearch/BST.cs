using System;
using System.Collections.Generic;
using System.Linq;
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
                if(p.getKey() < e)
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
            } else if (prev.getKey() < e)
            {
                prev.right = new BSTNode(e);
            }
            else
            {
                prev.left = new BSTNode(e);
            }
        }

        /*Recorrido por Fuerza Bruta*/
        public void breadthFirstSearch()
        {
            BSTNode p = root;
            LinkedQueueADT<BSTNode> queue = new LinkedQueueADT<BSTNode>();
            
        }

        public void depthFirstSearch()
        {

        }

        public void hillClimbing()
        {

        }

        public void bestFirstSearch()
        {

        }

        public void branchNBound()
        {

        }
    }
}
