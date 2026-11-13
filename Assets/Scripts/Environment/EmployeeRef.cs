using Environment;
using Environment.Tasks;
using System;
using System.Collections.Generic;
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
