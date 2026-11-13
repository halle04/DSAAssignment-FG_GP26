using System;
using UnityEngine;
using static Environment.Tasks.Employee;

namespace Environment.Tasks {
    public class EmployeeUI : MonoBehaviour {
        [SerializeField] private Transform content;
        [SerializeField] private GameObject employeeEntryPrefab;
        [SerializeField] private GameObject employeeScreen;

        [Header("Sorting Tasks")]
        [SerializeField] private AlphabeticalSortingTask alphabeticalSortingTask;
        [SerializeField] private EntranceTimeSortingTask entranceTimeSortingTask;
        [SerializeField] private BFSSearch BFS;

        [Header("Reset")]
        [SerializeField] private TextAsset originalEmployeeJson;

        private bool alphabeticalDescending = false;
        private bool entranceTimeDescending = false;

        public void PopulateEmployees(Employee[] employees) {
            foreach(Transform child in content) {
                Destroy(child.gameObject);
            }

            if(employees == null)
                return;

            foreach(Employee employee in employees) {
                GameObject entry = Instantiate(
                    employeeEntryPrefab,
                    content
                );

                EmployeeScreen employeeEntry =
                    entry.GetComponent<EmployeeScreen>();

                if(employeeEntry != null) {
                    employeeEntry.SetEmployee(employee);
                }
            }
        }

        public void OpenScreen() {
            if(employeeScreen != null)
                employeeScreen.SetActive(true);

            if(EmployeeRef.Instance != null)
                PopulateEmployees(EmployeeRef.Instance.employeeUser);
        }

        public void CloseScreen() {
            if(employeeScreen != null)
                employeeScreen.SetActive(false);
        }

        public void SortAlphabetically() {
            if(alphabeticalSortingTask == null) {
                Debug.LogError("Alphabetical Sorting Task is not assigned!");
                return;
            }

            if(EmployeeRef.Instance == null ||
                EmployeeRef.Instance.employeeUser == null) {
                Debug.LogError("Employee data is not loaded!");
                return;
            }

            alphabeticalSortingTask.Execute();

            if(alphabeticalDescending) {
                Array.Reverse(EmployeeRef.Instance.employeeUser);
            }

            alphabeticalDescending = !alphabeticalDescending;

            PopulateEmployees(EmployeeRef.Instance.employeeUser);
        }

        public void SortByEntranceTime() {
            if(entranceTimeSortingTask == null) {
                return;
            }

            entranceTimeSortingTask.Execute();

            if(entranceTimeDescending) {
                Array.Reverse(EmployeeRef.Instance.employeeUser);
            }

            entranceTimeDescending = !entranceTimeDescending;

            PopulateEmployees(EmployeeRef.Instance.employeeUser);
        }

        public void ResetVersion() {
            
            EmployeeArray data =
                JsonUtility.FromJson<EmployeeArray>(originalEmployeeJson.text);

            EmployeeRef.Instance.employeeUser = data.employees;

            alphabeticalDescending = false;
            entranceTimeDescending = false;

            PopulateEmployees(EmployeeRef.Instance.employeeUser);

            Debug.Log("Employee list reset to its original version.");
        }
    }
}
