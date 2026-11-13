using Environment.Tasks;
using NUnit.Framework.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class BSTNode<T>
{
    private T data;
    public BSTNode<T>? left = null;
    public BSTNode<T>? right = null;

    public T GetData() {
        return data;
    }
    public BSTNode(T data) {
        this.data = data;
    }
}

public class  BinarySearchTree {
    private BSTNode<Employee> root;

    public BinarySearchTree(Employee rootdata) {
        root = new BSTNode<Employee>(rootdata);
    }

    public void Insert(Employee indata) {
        BSTNode<Employee> newNode = new BSTNode<Employee>(indata);
        BSTNode<Employee>? currentNode = root;
        BSTNode<Employee> lastParent = root;
        while(currentNode != null) {
            if(DateTime.ParseExact(indata.LastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
                < DateTime.ParseExact(currentNode.GetData().LastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)) {
                lastParent = currentNode;
                currentNode = currentNode.left;
            }
            else {
                lastParent = currentNode;
                currentNode = currentNode.right;
            }
        }
        if(DateTime.ParseExact(indata.LastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
            < DateTime.ParseExact(lastParent.GetData().LastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)) {
            lastParent.left = newNode;
        }
        else {
            lastParent.right = newNode;
        }
    }

    public void BFS() {
        Queue<BSTNode<Employee>> queue = new Queue<BSTNode<Employee>>();
        queue.Enqueue(root);

        while(queue != null && queue.Count > 0) {
            BSTNode<Employee> node = queue.Dequeue();
            if(node == null ) {
                return;
            }
            Debug.Log(node.GetData().LastEntranceInEngineRoom);

            if(node.left != null) {
                queue.Enqueue(node.left);
            }
            if(node.right != null) {
                queue.Enqueue(node.right);
            }
        }
        

    }
}
