const TreeNode = require('./TreeNode');

class BinaryTree
{
    constructor(io)
    {
        this.io = io;
        this.root = null;
    }

    async createTree()
    {
        this.root = await this.#buildTreeInteractively("root node");
    }

    async #buildTreeInteractively(positionContext)
    {
        const data = await this.io.getIntInput(`Enter ${positionContext} (-1 for null): `);

        if(data === -1) return null;

        const node = new TreeNode(data);

        node.left = await this.#buildTreeInteractively(`left child of ${data}`);
        node.right = await this.#buildTreeInteractively(`right child of ${data}`);

        return node;
    }

    preOrder(node, result = []){
        if(!node) return result;
        result.push(node.data);
        this.preOrder(node.left, result);
        this.preOrder(node.right, result);
        return result;
    }

    inOrder(node, result = []){
        if(!node) return result;
        this.inOrder(node.left, result);
        result.push(node.data);
        this.inOrder(node.right, result);
        return result;
    }

    postOrder(node, result = []){
        if(!node) return result;
        this.postOrder(node.left, result);
        this.postOrder(node.right, result);
        result.push(node.data);
        return result;
    }

    levelOrder(root){
        if(!root) return [];
        const result = [];
        const queue = [root];
        while(queue.length > 0){
            const current = queue.shift();
            result.push(current.data);

            if(current.left) queue.push(current.left);
            if(current.right) queue.push(current.right);
        }
        return result;
    }
}

module.exports = BinaryTree;