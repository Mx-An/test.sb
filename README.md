# test.sb
class RBTree:
    def __init__(self):
        self.root = None

    def insert(self, key, value):
        if self.root is None:
            self.root = Node(key, value, BLACK, None)
            return
        parent = None
        t = self._get_node(key)
        if t is not None:
            t.value = value
            return
        node = Node(key, value, RED, parent)
        if parent.key < node.key:
            parent.right = node
        else:
            parent.left = node

        fix_insert(node, self)

    def delete(self, key):
        x = self._get_node(key)
        if x is None:
            return
        if left_child(x) is not None and right_child(x) is not None:
            real_delete = get_successor(x)
            x.key = real_delete.key
            x.value = real_delete.value
            x = real_delete
        # 到此，x最多也就一个孩子了
        successor = get_one_child(x)
        if successor is None:
            self._delete_leaf(x)
            return

        if get_parent(x) is None:
            self.root = None
        elif x is left_child(get_parent(x)):
            get_parent(x).left = successor
        else:
            get_parent(x).right = successor

        if get_color(x) is BLACK:
            fix_delete(successor, self)



