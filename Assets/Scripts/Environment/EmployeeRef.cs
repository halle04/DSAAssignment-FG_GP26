using Environment;
using Environment.Tasks;
using System;
using UnityEngine;


    public class EmployeeRef : MonoBehaviour
    {
        public static EmployeeRef Instance;

    public Employee[] employeeUser;

        public void Awake()
        {
        Instance = this;
        }
    }
