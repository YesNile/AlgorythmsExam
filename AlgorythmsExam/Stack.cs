﻿using System.Collections;

namespace AlgorythmsExam;

public class NodeStack<TValue>
{
    public NodeStack(TValue value)
    {
        Value = value;
    }
    public NodeStack<TValue> Next;
    public NodeStack<TValue> Previous;
    public TValue Value;
}
public class MyLinkedList<TValue>:IEnumerable<TValue>
{
    public NodeStack<TValue> Head;
    public NodeStack<TValue> Tail;
    public int Count { get; private set; } = 0;

    public bool IsEmpty()
    {
        return Head == null && Tail == null;
    }
    public void Add(TValue value)
    {
        var node = new NodeStack<TValue>(value);
        var temp = Head;
        node.Next = temp;
        Head = node;
        if (Count == 0)
            Tail = Head;
        else
            temp.Previous = node;
        Count++;
    }

    public void AddLast(TValue value)
    {
        var node = new NodeStack<TValue>(value);
        if (Head == null)
        {
            Head = node;
        }
        else
        {
            Tail.Next = node;
            node.Previous = Tail;
        }
        Tail = node;
        Count++;
    }

    public TValue RemoveFirst()
    {
        var value = Head.Value;
        var temp = Head.Next;
        if (temp != null)
        {
            temp.Previous = null;
        }
        Head = temp;
        Count = Count ==0?0:Count--;
        return value;
    }
    public TValue RemoveLast()
    {
        var value = Tail.Value;
        var temp = Tail.Previous;
        if (temp != null)
        {
            temp.Next = null;
        }
        Tail = temp;
        Count = Count ==0?0:Count--;
        return value;
    }

    public IEnumerator<TValue> GetEnumerator()
    {
        var node = Head;
        while (node != null)
        {
            yield return node.Value;
            node = node.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
public class Stack<TValue>:IEnumerable<TValue>
{
    
    private MyLinkedList<TValue> list = new MyLinkedList<TValue>();
    public int Count { get; private set; } = 0;
    public void Push(TValue value)
    {
        Count++;
        list.AddLast(value);
    }

    public TValue Pop()
    {
        Count = Count ==0?0:Count-1;
        return list.RemoveLast();
    }

    public TValue Top()
    {
        return list.Tail.Value;
    }

    public bool IsEmpty()
    {
        return list.IsEmpty();
    }

    public IEnumerator<TValue> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}