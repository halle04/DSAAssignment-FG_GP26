using System;
using System.Collections.Generic;
using UnityEngine;

//add
namespace Utils {
    [Serializable]
    public class GenericQueue<T> {
        public List<T> Queue;

        public GenericQueue() {
            Queue = new List<T>();
        }

        public void Enqueue(T Item) {
            Queue.Add(Item);
        }

        public T Peek() {
            if(Queue.Count == 0) {
                throw new Exception("queue is empty, cannot peek");
            }

            return Queue[0];
        }

        public T Dequeue() {
            if(Queue.Count == 0) {
                throw new Exception("queue is empty, cannot dequeue");
            }

            T topOfQueue = Queue[0];
            Queue.RemoveAt(index: 0);
            return topOfQueue;
        }

        public void Clear() {
            Queue.Clear();
        }

    }
}
