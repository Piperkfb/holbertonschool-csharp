﻿﻿using System;

///<summary>Class for que opperations</summary>
class Queue<T>
{
    ///<summary>Check if its a queue type</summary>
	public Type CheckType()
	{
		return typeof(T);
	}
	
    
     /// <summary>Class Node inside queue class</summary>
	public class Node
	{
		public T value;
		public Node next = null;

		public Node(T stri)
		{
			value = stri;
		}
	}

	public Node head;
	public Node tail;
	public int count;

	///<summary>Add new node at the end</summary>
	public void Enqueue(T value)
	{
		Node newnode = new Node(value);
		if (head == null)
		{
			head = newnode;
			tail = newnode;
		}
		else
		{
			tail.next = newnode;
			tail = newnode;
		}
		count++;
	}




	///<summary>Add new node at the end</summary>
	public int Count()
	{
		return count;
	}


  ///<summary> deleting the firts node</summary>
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			tail.value = head.value;
			head = head.next;
			count--;
			return tail.value;
		}
	}

    ///<summary>return value firts node</summary>
	public T Peek()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			return head.value;
		}
	}

}