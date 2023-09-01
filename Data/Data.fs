module Data
open System.Text.Json
open System
open System.Threading


let getJson value =
    let json = JsonSerializer.Serialize(value)
    value, json

type EmployeeModel = {
    firstName: string
    lastName: string
}
let employees = [
    {firstName="Juan"; lastName="Rodriguez"}
    {firstName="Ivan"; lastName="Montilla"}
    {firstName="Abiel"; lastName="Pimentel"}
    {firstName="Jhonny"; lastName="Jones"}
    {firstName="Sara"; lastName="Perez"}
    {firstName="Josh"; lastName="Trevol"}
    {firstName="Agustin"; lastName="Lara"}
    {firstName="Julio"; lastName="Mendez"}
]
let getEmployees  =
   task{
    Thread.Sleep(3000)
    return employees
   }
    