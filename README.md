## BinaryTrees<br>

### Intro
There are four projects in the solution<br>
1. Trees: A console application. There is no code but you may wish to add some for testing.
2. Trees.Classes: A class library. This is where most of the code you write will go. All the other projects have references to it.
3. Trees.Gui: A gui application to display the binary search tree. It has been written using a Microsoft technology called Maui, chosen because it should (fingers crossed) work on both Mac and Windows.
4. Trees.Tests: Contains tests

Note: To switch between running the console app Trees and the maui app Trees.Gui right click on the project and select Set as Startup Project.</br> 

### Tasks
1. Start by running Trees.Gui. You should be able to add items (strings only) to a binary tree and view the tree on the display.<br>
There are buttons to remove nodes and to perform an in order traversal however these do not work yet.<br>
The main class is DrawableTree<T>. It inherits from BinaryTree<T>. This class is in Trees.Classes.
2. Implement all of the methods in BinaryTree. You should start with the add methods. These include methods to add nodes to the tree, traverse the tree and remove nodes. You can add other private methods if you wish but do not change the signature of the public methods.<br>
3. Once the methods have been implemented correctly the tests in Trees.Tests should pass. You should also use the gui to test that the in order traversal and the remove method now work correctly.<br>

### Extension
1. See if you can change the Display In Order button in the gui so that it is a drop down and shows in order, pre order or post order traversals of the tree depending on which option the user selects. <br>
2. See if you can allow the user to select (or infer) the data type for the tree to allow them to add numbers instead of strings.
