package mybst;

public class TreeNode <E> {

    E element;
    TreeNode<E> left;
    TreeNode<E> right;


public TreeNode(E element) {
  this.element = element;

  }


    E getNode() {
        return element;
    }

    void setNode(E node) {
        this.node = node;
    }

    String getType() {
        return node.getClass().getName();
    }
}
