using System;
using System.Collections.Generic;

namespace Utils {
    public class GenericQueue<T> {
        private List<T> Queue;

        public GenericQueue(T InNewElement) {
            Queue = new List<T>();
        }

        public void Enqueue(T InNewElement) {
            Queue.Add(InNewElement);
        }

        public T Peek() {
            if(Queue.Count == 0) {
                throw new Exception("queue is empty, cannot peek");
            }

            return Queue[0];
        }

        public T Dequeue(T InElement) {
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
