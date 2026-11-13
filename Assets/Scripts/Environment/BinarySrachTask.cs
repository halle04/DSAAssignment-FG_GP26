
using System;
using System.Diagnostics;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "BinarySearch", menuName = "Scriptable Objects/BinarySearch")]
    public class BinarySearchTask : Task {
        public override void Execute() {
            Employee[] employees = EmployeeRef.Instance.employeeUser;

            Array.Sort(employees, (a, b) =>
                DateTime.Parse(a.LastEntranceInEngineRoom).CompareTo(
                DateTime.Parse(b.LastEntranceInEngineRoom)));

            Stopwatch stopwatch = Stopwatch.StartNew();

            BinarySearch search = new BinarySearch();
            int result = search.BiSearch(employees,
                DateTime.Parse(employees[0].LastEntranceInEngineRoom));

            stopwatch.Stop();

            UnityEngine.Debug.Log("Result: " + result);
            UnityEngine.Debug.Log("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}
