// See https://aka.ms/new-console-template for more information
using DataStructure.CircularLinkList;
using DataStructure.DoublyLinkedList;
using DataStructure.LinkedList;
using DataStructure.Trees;


//Console.WriteLine("====================== Singly Link List insert at first =============================");
//var linkList = new SinglyLinkedList();
//linkList.DisplayList();
//linkList.InsertAtFirstLinkList(1);
//linkList.InsertAtFirstLinkList(2);
//linkList.InsertAtFirstLinkList(3);
//linkList.InsertAtFirstLinkList(4);
//linkList.DisplayList();


//Console.WriteLine("====================== Singly Link List insert at end =============================");
//var linkListobj = new SinglyLinkedList();
//linkListobj.DisplayList();
//linkListobj.InsertAtFirstLinkList(1);
//linkListobj.InsertAtFirstLinkList(2);
//linkListobj.InsertAtFirstLinkList(3);
//linkListobj.InsertAtFirstLinkList(4);
//linkListobj.DisplayList();

//Console.WriteLine("====================== Singly Link List delete from front =============================");
//var linkListobj = new SinglyLinkedList();
//linkListobj.InsertAtEnd(1);
//linkListobj.InsertAtEnd(2);
//linkListobj.InsertAtEnd(3);
//linkListobj.InsertAtEnd(4);
//Console.WriteLine("====================== display start =============================");
//linkListobj.DisplayList();
//Console.WriteLine("====================== display end =============================");
//var val = linkListobj.DeleteAtFirst();
//Console.WriteLine($"deleted value =>{val}");
//Console.WriteLine("====================== after deleting from front =============================");
//linkListobj.DisplayList();

//Console.WriteLine("====================== Singly Link List delete from end =============================");
//var linkListobj = new SinglyLinkedList();
//linkListobj.InsertAtEnd(1);
//linkListobj.InsertAtEnd(2);
//linkListobj.InsertAtEnd(3);
//linkListobj.InsertAtEnd(4);
//Console.WriteLine("====================== display start =============================");
//linkListobj.DisplayList();
//Console.WriteLine("====================== display end =============================");
//var val = linkListobj.DeleteFromLast();
//Console.WriteLine($"deleted value =>{val}");
//Console.WriteLine("====================== after deleting from end =============================");
//linkListobj.DisplayList();

/*
Console.WriteLine("====================== Doubly link list insert at first=============================");
var DL = new DoublyLinkedList();
DL.Display();
DL.InsertAtFirst(1);
DL.InsertAtFirst(2);
DL.InsertAtFirst(3);
DL.InsertAtFirst(4);
DL.Display();
*/

/*
Console.WriteLine("====================== Doubly link list INSERT AT END=============================");
var DL = new DoublyLinkedList();
DL.Display();
DL.InsertAtEnd(1);
DL.InsertAtEnd(2);
DL.InsertAtEnd(3);
DL.InsertAtEnd(4);
DL.Display();
*/

/*
Console.WriteLine("====================== Doubly link list INSERT AFTER=============================");
var DL = new DoublyLinkedList();
DL.Display();
DL.InserAfterNode(1, 1);
DL.InsertAtEnd(2);
DL.InsertAtEnd(4);
DL.Display();
DL.InserAfterNode(2,3);
DL.Display();
DL.InserAfterNode(4,5);
DL.Display();
DL.InserAfterNode(6, 7);
DL.Display();

*/



//Console.WriteLine("====================== Circular link list=============================");
//var CL = new CircularLinkList();
//CL.Display();
//CL.InsertIntoList(1);
//CL.InsertIntoList(2);
//CL.InsertIntoList(3);
//CL.InsertIntoList(4);
//CL.Display();


/*

Console.WriteLine("====================== Circular link list delete=============================");
var CL = new CircularLinkList();
CL.Display();
CL.InsertIntoList(1);
CL.InsertIntoList(2);
CL.InsertIntoList(3);
CL.InsertIntoList(4);
CL.Display();
CL.DeleteFromList(1);
CL.Display();
CL.DeleteFromList(3);
CL.Display();
CL.DeleteFromList(4);
CL.Display();
*/

int[] nodes = new int[] { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };

var tree = new BinaryTree();

var node = tree.BuildTree(nodes);

Console.WriteLine("Root node");
Console.WriteLine(node.data);
Console.WriteLine("==================PREORDER=================");

tree.PreOrder(node);
Console.WriteLine("==================INORDER=================");
tree.InOrder(node);
Console.WriteLine("==================POSTORDER=================");
tree.PostOrder(node);






