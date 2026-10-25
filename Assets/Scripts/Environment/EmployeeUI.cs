using UnityEngine;

namespace Environment.Tasks {
    public class EmployeeUI : MonoBehaviour {
        [SerializeField] private Transform content;
        [SerializeField] private GameObject employeeEntryPrefab;
        [SerializeField] private GameObject employeeScreen;
        public void PopulateEmployees(Employee[] employees) {
            // Clear existing entries
            foreach(Transform child in content) {
                Destroy(child.gameObject);
            }

            if(employees == null)
                return;

            // Create an entry for every employee
            foreach(Employee employee in employees) {
                GameObject entry = Instantiate(
                    employeeEntryPrefab,
                    content
                );

                EmployeeScreen employeeEntry =
                    entry.GetComponent<EmployeeScreen>();

                employeeEntry.SetEmployee(employee);
            }
        }
        public void OpenScreen() {
            employeeScreen.SetActive(true);

            PopulateEmployees(EmployeeRef.Instance.employeeUser);
        }
        public void CloseScreen() {
            employeeScreen.SetActive(false);
        }
    }
}
