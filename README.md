# Interfaces - C#

#### This exercise is based on the <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/?couponCode=MT260714G2">"C# COMPLETO Programação Orientada a Objetos + Projetos"</a> course.

#### This repository covers the use of Interfaces in C#.

### <ins>Work with Interface - Example problem</ins>

#### A Brazilian car rental company charges an hourly rate for rentals of up to 12 hours. However, if the rental duration exceeds 12 hours, the rental will be charged based on a daily rate.

#### In addition to the rental fee, a tax is added to the price according to the country's regulations. In Brazil, the tax is 20% for amounts up to 100.00, or 15% for amounts above 100.00.

#### Write a program that reads the rental data (car model, start date and time, and end date and time), as well as the hourly and daily rental rates. The program should then generate a payment statement containing the rental amount, tax amount, and total payment amount, and display the information on the screen.

#### See the examples below.

#### <ins>Example 1:</ins>

Enter rental data<br>
Car model: <strong>Civic</strong><br>
Pickup (dd/MM/yyyy hh:mm): <strong>25/06/2026 10:30</strong><br>
Return (dd/MM/yyyy hh:mm): <strong>25/06/2026 14:40</strong><br>
Enter price per hour: <strong>10.00</strong><br>
Enter price per day: <strong>130.00</strong><br>
INVOICE:<br>
Basic payment: 50.00<br>
Tax: 10.00<br>
Total payment: 60.00

#### <ins>Example 2:</ins>

Enter rental data<br>
Car model: <strong>Civic</strong><br>
Pickup (dd/MM/yyyy hh:mm): <strong>25/06/2026 10:30</strong><br>
Return (dd/MM/yyyy hh:mm): <strong>27/06/2026 11:40</strong><br>
Enter price per hour: <strong>10.00</strong><br>
Enter price per day: <strong>130.00</strong><br>
INVOICE:<br>
Basic payment: 390.00<br>
Tax: 58.50<br>
Total payment: 448.50