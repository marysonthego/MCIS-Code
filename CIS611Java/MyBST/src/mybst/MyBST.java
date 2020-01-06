package myBST;

/*
 * A binary search tree (with no duplicate elements)
has the property that for every node in the tree the
value of any node in its left subtree is less than the
value of the node and the value of any node in its
right subtree is greater than the value of the node.
 */

public class MyBST<E> {

    E node;
    TreeNode<E> root;
    TreeNode<E> parent;

    MyBST(E node) {
        this.node = new TreeNode<E>(node);
    }

public boolean searchTree(E element) {
    TreeNode<E> current = root;

    while (current != null) {
        if (element < current.element) {
            current = current.left; //go left
        }
        else if (element > current.element) {
            current = current.right; //go right
        }
        else //element = current.element
            return true;
    }
    return false; //element is not in the tree
}

public boolean addTreeNode(E element) {
    TreeNode<E> current = root;
    if (root == null) {
        root = new TreeNode(element);
        return true;
    }
    else {
        current = root;
        while (current != null) {
            if (element < current.element) {
                parent = current;
                current = current.left;
            }
            else if (element > current.element) {
                parent = current;
                current = current.right;
            }
            else
                return false; //duplicate node not added
        }
        if (element < parent.element)
            parent.left = new TreeNode(element);
        else
            parent.right = new TreeNode(element);

        return true;
    }
}

    public static void main(String[] args) {


    }
}