const ConsoleIO = require('./ConsoleIO');
const BinaryTree = require('./BinaryTree');

async function main()
{
    const io = new ConsoleIO();
    const tree = new BinaryTree(io);

    console.log("___Tree Creation___");
    await tree.createTree();

    console.log("\n___Traversals___");
    console.log("Pre-Order: ", tree.preOrder(tree.root).join(" "));
    console.log("In-Order: ", tree.inOrder(tree.root).join(" "));
    console.log("Post-Order: ", tree.postOrder(tree.root).join(" "));
    console.log("Level-Order: ", tree.levelOrder(tree.root).join(" "));

    io.close();
}
main();