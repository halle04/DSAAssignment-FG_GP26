using System.Threading.Tasks;
using UnityEngine;

namespace Environment.Tasks {

    [CreateAssetMenu(fileName = "BFSSeatch", menuName = "Scriptable Objects/BFSSeatch")]
    public class BFSSearch : Task {
        public override void Execute() {
            BinarySearchTree bst = new BinarySearchTree(EmployeeRef.Instance.employeeUser[0]);
            for(int i = 1; i < EmployeeRef.Instance.employeeUser.Length; i++) {
                bst.Insert(EmployeeRef.Instance.employeeUser[i]);
            }
            bst.BFS();
            Debug.Log("BFS search completed.");
        }
    }
}
