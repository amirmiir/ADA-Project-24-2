using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADATreeSearch
{
    public class BSTMain
    {
        public static void Main(string[] args)
        {
            BSTMain bstMain = new BSTMain();
            bstMain.Custom();
        }

        public void Custom()
        {
            BST tree = new BST();
            /*
             * 
             */
            tree.insert(10);
            tree.insert(5);
            tree.insert(20);
            tree.insert(4);
            tree.insert(6);
            tree.insert(15);
            tree.insert(30);
            tree.insert(0);
            tree.insert(7);
            tree.insert(13);
            tree.insert(8);

            tree.Actions();
        }
        
        public void Actions()
        {

        }


    }
}
