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

### <ins>Interface - Exercise01</ins>

#### A company wants to automate the processing of its contracts. Processing a contract consists of generating the installments to be paid for that contract, based on the desired number of months.

#### The company uses an online payment service to process the installment payments. Online payment services typically charge monthly interest as well as a fee per payment. For now, the payment service contracted by the company is PayPal, which applies simple interest of 1% per installment, plus a payment fee of 2%.

#### Develop a program to read the contract data (contract number, contract date, and total contract amount). Then, the program should read the number of months for the installment plan and generate the installment records to be paid (date and amount). The first installment must be paid one month after the contract date, the second installment two months after the contract date, and so on.

#### Finally, display the installment data on the screen.

#### Example:

Enter contract data<br>
Number: <strong>8028</strong><br>
Date (dd/MM/yyyy): <strong>25/06/2018</strong><br>
Contract value: <strong>600.00</strong><br>
Enter number of installments: <strong>3</strong><br>
Installments:<br>
25/07/2018 - 206.04<br>
25/08/2018 - 208.08<br>
25/09/2018 - 210.12

### <ins>Interface with Abstract Inheritance</ins>

#### Similarities Bethween Interfaces and Inheritance:

#### Is-a relationship
#### Generalization/specialization
#### Polymorphism

#### Inheritance and Interfaces can be used together in the same project, allowing you to have both generic and specialized objects. See the example UML diagram below:

<img src="InterfaceWithAbstractInheritance\Imagens\InterfaceWithAbstractInheritance-UML.png" alt="Interface with Abstract Inheritance - UML">