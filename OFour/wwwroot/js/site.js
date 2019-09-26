async function getStudent() {
    const url = "http://localhost:5008/api/Student";
    let response = await fetch(url);
    let data = await response.json();


    let tableRow = document.querySelector(".list");

    let tableRowStudentFirstName = document.createElement("td");
    let tableRowStudentLastName=document.createElement("td");
    let tableRowStudentBirthDate=document.createElement("td");
    let tableRowStudentEmail=document.createElement("td");
    let tableRowStudentPhone=document.createElement("td");
    let tableRowStudentCourse=document.createElement("td");
    let tableRowStudentStatuse=document.createElement("td");
    let tableRowStudentStartDate=document.createElement("td");
    let tableRowTeacherFirstName=document.createElement("td");
    let tableRowTeacherLastName=document.createElement("td");
    

    








    


    tableRowStudentFirstName.innerHTML = data[0].firstName;
    tableRowStudentLastName.innerHTML=data[0].lastName;
    tableRowStudentBirthDate.innerHTML=data[0].birthDate;
    tableRowStudentEmail.innerHTML=data[0].email;
    tableRowStudentPhone.innerHTML=data[0].phone;
    tableRowStudentCourse.innerHTML=data[0].course;
    tableRowStudentStatuse.innerHTML=data[0].statuse;
    tableRowStudentStartDate.innerHTML=data[0].startDate;
    tableRowTeacherFirstName.innerHTML=data[0].teacherFirstName;
    tableRowTeacherLastName.innerHTML=data[0].teacherLastName;
    




    

    



    tableRow.appendChild(tableRowStudentFirstName);
    tableRow.appendChild(tableRowStudentLastName);
    tableRow.appendChild(tableRowStudentBirthDate);
    tableRow.appendChild(tableRowStudentEmail);
    tableRow.appendChild(tableRowStudentPhone);
    tableRow.appendChild(tableRowStudentCourse);
    tableRow.appendChild(tableRowStudentStatuse);
    tableRow.appendChild(tableRowStudentStartDate);
    tableRow.appendChild(tableRowTeacherFirstName);
    tableRow.appendChild(tableRowTeacherLastName);












   



}




let btn = document.querySelector("#btn");

btn.addEventListener("click", getStudent);