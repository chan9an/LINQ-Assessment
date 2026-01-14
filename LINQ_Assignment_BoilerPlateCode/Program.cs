using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Assignment_BoilerPlateCode.Repos;
using LINQ_Assignment_BoilerPlateCode.DTOs;
using LINQ_Assignment_BoilerPlateCode.Models;

namespace LINQ_Assignment_BoilerPlateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = EmployeeRepo.SeedEmployees();
            var projects = ProjectRepo.SeedProjects();

            Console.WriteLine("LINQ Scenario Boilerplate Loaded");
        }

        // =====================================================
        // 🟢 SECTION 1 – HR ANALYTICS
        // =====================================================

        static List<Employee> GetHighEarningEmployees(List<Employee> employees)
        {
            return employees.Where(e => e.Salary > 60000).ToList();
        }

        static List<string> GetEmployeeNames(List<Employee> employees)
        {
            return employees.Select(e => e.Name).ToList();
        }

        static bool HasHREmployees(List<Employee> employees)
        {
            return employees.Any(e => e.Department == "HR");
        }

        // =====================================================
        // 🟡 SECTION 2 – MANAGEMENT INSIGHTS
        // =====================================================

        static List<DepartmentCount> GetDepartmentWiseCount(List<Employee> employees)
        {
            return employees
                .GroupBy(e => e.Department)
                .Select(g => new DepartmentCount
                {
                    Department = g.Key,
                    Count = g.Count()
                })
                .ToList();
        }

        static Employee GetHighestPaidEmployee(List<Employee> employees)
        {
            return employees.OrderByDescending(e => e.Salary).FirstOrDefault();
        }

        static List<Employee> SortEmployeesBySalaryAndName(List<Employee> employees)
        {
            return employees
                .OrderByDescending(e => e.Salary)
                .ThenBy(e => e.Name)
                .ToList();
        }

        // =====================================================
        // 🔵 SECTION 3 – PROJECT & SKILL INTELLIGENCE
        // =====================================================

        static List<EmployeeProject> GetEmployeeProjectMappings(
            List<Employee> employees,
            List<Project> projects)
        {
            throw new NotImplementedException();
        }

        static List<Employee> GetUnassignedEmployees(
            List<Employee> employees,
            List<Project> projects)
        {
            throw new NotImplementedException();
        }

        static List<string> GetAllUniqueSkills(List<Employee> employees)
        {
            throw new NotImplementedException();
        }

        // =====================================================
        // 🔴 SECTION 4 – ADVANCED WORKFORCE ANALYTICS
        // =====================================================

        static List<DepartmentTopEmployees> GetTopEarnersByDepartment(
            List<Employee> employees)
        {
            throw new NotImplementedException();
        }

        static List<Employee> RemoveDuplicateEmployees(List<Employee> employees)
        {
            throw new NotImplementedException();
        }

        static List<Employee> GetEmployeesByPage(
            List<Employee> employees,
            int pageNumber,
            int pageSize = 5)
        {
            throw new NotImplementedException();
        }
    }
}
