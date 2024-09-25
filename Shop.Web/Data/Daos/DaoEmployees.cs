using Shop.Web.Data.Context;
using Shop.Web.Data.Dtos;
using Shop.Web.Data.Entities;
using Shop.Web.Data.Exceptions;
using Shop.Web.Data.Interfaces;
using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;

namespace Shop.Web.Data.Daos
{
    public class DaoEmployees : IEmployees
    {
        private readonly ShopDbContext shopDb;
        private readonly ILogger<DaoEmployees> logger;

        public DaoEmployees(ShopDbContext shopDb, ILogger<DaoEmployees> logger)
        {
            this.shopDb = shopDb;
            this.logger = logger;
        }

        //public ShopDbContext ShopDb { get; }

        public List<EmployeesAddDto> GetEmployees()
        {
            List<EmployeesAddDto> employees = new List<EmployeesAddDto>();
            try
            {
                employees = (from empls in this.shopDb.Employees
                             where empls.deleted == false
                             /*orderby empls.creation_date descending*/
                             select new EmployeesAddDto()
                             {
                                 empid = empls.empid,
                                 firstname = empls.firstname,
                                 lastname = empls.lastname,
                                 title = empls.title,
                                 titleofcourtesy = empls.titleofcourtesy,
                                 address = empls.address,
                                 city = empls.city,
                                 birthdate = empls.birthdate,
                                 phone = empls.phone,
                                 hiredate = empls.hiredate,
                                 country = empls.country,
                                 creation_date = empls.creation_date,
                                 creation_user = empls.creation_user
                             }).ToList();

            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error obteniendo los empleados {ex}", ex.ToString());
            }
            return employees;
        }

        public EmployeesAddDto GetEmployeesById(int employeesId)
        {
            EmployeesAddDto employeesResult = new EmployeesAddDto();


            try
            {
                var employee = this.shopDb.Employees.Find(employeesId);

                if (employee is null)
                {
                    throw new EmployeeException("El empleado no se encuentra registrado.");
                }
                employeesResult.empid = employee.empid;
                employeesResult.address = employee.address;
                employeesResult.phone = employee.phone;
                employeesResult.firstname = employee.firstname;
                employeesResult.lastname = employee.lastname;
                employeesResult.creation_date = employee.creation_date;
                employeesResult.creation_user = employee.creation_user;
                employeesResult.country = employee.country;
                employeesResult.title = employee.title;
                employeesResult.birthdate = employee.birthdate;
                employeesResult.city = employee.city;
                employeesResult.hiredate = employee.hiredate;

            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error obteniendo los empleados {ex}", ex.ToString());
            }

            return employeesResult;
        }

        public void RemoveEmployees(EmployeesRemoveDto removeDto)
        {
            if (removeDto is null)
            {
                throw new EmployeeException("El objeto empleado no puede ser nulo.");
            }

            try
            {
                var employee = this.shopDb.Employees.Find(removeDto.empid);

                if (employee is null)
                {
                    throw new EmployeeException("El empleado no se encuentra registrado.");
                }

                employee.deleted = true;
                employee.delete_user = removeDto?.delete_user;
                employee.delete_date = removeDto?.delete_date;

            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error romoviendo el empleado {ex}", ex.ToString());
            }
        }

        public void SaveEmployees(EmployeesAddDto addDto)
        {

            try
            {
                if (addDto is null)
                {
                    throw new EmployeeException("El empleado no se encuentra registrado.");
                }


                Employees employees = new Employees()
                {

                    firstname = addDto.firstname,
                    lastname = addDto.lastname,
                    title = addDto.title,
                    titleofcourtesy = addDto.titleofcourtesy,
                    address = addDto.address,
                    city = addDto.city,
                    birthdate = addDto.birthdate,
                    phone = addDto.phone,
                    hiredate = addDto.hiredate,
                    country = addDto.country,
                    creation_date = addDto.creation_date,
                    creation_user = addDto.creation_user
                };
                this.shopDb.Employees.Update(employees);
                this.shopDb.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error grabando el empleado {ex}", ex.ToString());
            }
        }

        public void UpdateEmployees(EmployeesUpdateDto updateDto)
        {
            try
            {
                if (updateDto is null)
                {
                    throw new EmployeeException("El objeto empleado no puede ser nulo.");
                }

                Employees employees = this.shopDb.Employees.Find(updateDto.empid);
                {

                    if (employees is null)
                    {
                        throw new EmployeeException("El empleado no se encuentra registrado.");
                    }

                    employees.empid = updateDto.empid;
                    employees.firstname = updateDto.firstname;
                    employees.lastname = updateDto.lastname;
                    employees.title = updateDto.title;
                    employees.address = updateDto.address;
                    employees.city = updateDto.city;
                    employees.birthdate = updateDto.birthdate;
                    employees.phone = updateDto.phone;
                    employees.hiredate = updateDto.hiredate;
                    employees.country = updateDto.country;
                    employees.modify_date = updateDto.modify_date;
                    employees.modify_user = updateDto.modify_user;



                };
                this.shopDb.Employees.Update(employees);
                this.shopDb.SaveChanges();

            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error grabando el empleado {ex}", ex.ToString());
            }
        }
    }
}
