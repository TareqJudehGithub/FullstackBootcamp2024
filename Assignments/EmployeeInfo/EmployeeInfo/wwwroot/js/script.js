console.log("JS online and running!");

let username = "admin";
console.log(username);

let password = "pass";
console.log(password);

let socialSecurity = .075;
let tax = .05;

// Check Login Credentials
function CheckLogin() {  
    let usernameInput = document.getElementById('userName');
    let usernameValue = usernameInput.value;

    let passInput = document.getElementById('password');
    let passValue = passInput.value;

    let salary = 1000;   
    let netSalary = salary + (salary * socialSecurity) + (salary * tax);

    if (usernameValue == username && passValue == password)
    {     
       // Apply this: window.location.href = 'emp-info.html';

        let name = "John Smith";
        alert("Welcome back, " + name);
        document.write(
            '<h1>Employee Details</h1>\n' +
            '<h3>Contacts</h3>\n' +
            '<p><strong>Name: </strong>John Smith</p>\n' +
            '<p><strong>E-mail: </strong>example@email.com</p>\n' +
            '<p><strong>Mobile: </strong>962 79 123456</p>\n' +
            '<h3>Salary Details</h3>\n' +
            '<p><strong>Salary:</strong> $' + salary + '</p>\n' +
            '<p><strong>Social Security:</strong> 7.5%</p>\n' +
            '<p><strong>Income Tax:</strong> 5%</p>\n' +
            '<p><strong> Net Salary:</strong>  $' + netSalary + '</p>\n'
        )           
    }  
    else
    {
        alert("Invalid username or password");
    }
}

