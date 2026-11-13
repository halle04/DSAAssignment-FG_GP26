using System.Diagnostics;
using System.Threading.Tasks;
using UnityEngine;

namespace Environment.Tasks {

    [CreateAssetMenu(fileName = "BFSSeatch", menuName = "Scriptable Objects/BFSSeatch")]
    public class BFSSearch : Task {

        Stopwatch stopwatch = new Stopwatch();
        public override void Execute() {
            
            stopwatch.Start();
            BinarySearchTree bst = new BinarySearchTree(EmployeeRef.Instance.employeeUser[0]);
            for(int i = 1; i < EmployeeRef.Instance.employeeUser.Length; i++) {
                bst.Insert(EmployeeRef.Instance.employeeUser[i]);
            }
            bst.BFS();
            UnityEngine.Debug.Log("BFS search completed.");
            stopwatch.Stop();
            UnityEngine.Debug.Log("Time taken for BFS search:" + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}
