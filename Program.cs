using System;
using System.Collections.Generic;
 
class Program
{
 
public class Branch
{
    public int key;
    public List<Branch> child;
};
 
static Branch newBranch(int key) //Should be called "nodes".
{
    Branch obj = new Branch();
    obj.key = key;
    obj.child = new List<Branch>();
    return obj;
}

// Recursive structure traverse:
static int depthOfStructure(Branch branch)
{
    // Base case
    if (branch == null)
        return 0;
    
    int maxdepth = 0;
    foreach (Branch i in branch.child)
        maxdepth = Math.Max(maxdepth, depthOfStructure(i));
 
    return maxdepth + 1 ;
}
 
// Driver Code
public static void Main(String[] args)
{
     
    /* Tree structure in the assignment:
    * 
    *             0        level 1
    *            / \ 
    *           1  2       level 2
    *          / /| \
    *        3  4 5  6     level 3
    *          /  |\   
    *         7   8 9      level 4
    *           |
    *          10          level 5 (Depth = 5)
    */
    
    Branch root = newBranch(0);
    (root.child).Add(newBranch(1));
    (root.child).Add(newBranch(2));
    (root.child[0].child).Add(newBranch(3));
    (root.child[1].child).Add(newBranch(4));
    (root.child[1].child).Add(newBranch(5));
    (root.child[1].child).Add(newBranch(6));
    (root.child[1].child[0].child).Add(newBranch(7));
    (root.child[1].child[1].child).Add(newBranch(8));
    (root.child[1].child[1].child).Add(newBranch(9));
    (root.child[1].child[1].child[0].child).Add(newBranch(10));
    
    Console.Write("Depth of the current structure: " + depthOfStructure(root));
}
}