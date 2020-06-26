import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { Student } from './../models/Student';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent implements OnInit {

  public studentForm: FormGroup;
  public title = 'Lista de Alunos';
  public selectedStudent: Student;
  public modalReference: BsModalRef;
  public modalConfig = {
    animated: true
  };

  public students = [
    { id: "72143DA8-799B-4962-A8AE-EF926FE299C5", firstname: 'Clark', lastname: 'Kent', phonenumber: '11933225555', document: '455.278.840-00', email: 'clarkkent@yahoo.com'},
    { id: "0530841D-AA4A-4469-9F6D-8DD39C75BD51", firstname: 'Leon', lastname: 'Kennedy', phonenumber: '21999880033', document: '860.187.460-69', email: 'leonskennedy@hotmail.com'},
    { id: "22E5557C-A61E-476F-A996-09FAB7DFF0AD", firstname: 'Bruce', lastname: 'Wayne', phonenumber: '47933442121', document: '730.648.440-08', email: 'brucewayne@gmail.com'},
    { id: "B36F6B51-3F95-4B3E-95C0-19099A78E825", firstname: 'Tony', lastname: 'Stark', phonenumber: '1397674944', document: '704.332.760-10', email: 'stark@yahoo.com'},
    { id: "B76B460B-3F15-4D71-9B31-1C0EFA20D0DE", firstname: 'Bruce', lastname: 'Benner', phonenumber: '45998877664', document: '819.391.990-42', email: 'hulk@hotmail.com'},
    { id: "E8E0015B-1EB1-444C-AF78-C0DCDE508109", firstname: 'Scooby', lastname: 'Doo', phonenumber: '11945492790', document: '268.910.380-06', email: 'scooby@yahoo.com'},
    { id: "B1FE8B94-1773-443A-9E04-52753571F3D3", firstname: 'Charlie', lastname: 'Brown', phonenumber: '34977553040', document: '236.780.220-30', email: 'charliebrown@hotmail.com'},
  ];

  constructor(private formBuilder: FormBuilder,
              private modalService: BsModalService) {
    this.createForm();
  }

  ngOnInit() {
  }

  createForm() {
    this.studentForm = this.formBuilder.group({
      firstname: ['', [Validators.pattern(/[a-zA-Z ]+$/), Validators.required, Validators.minLength, Validators.maxLength]],
      lastname: ['', [Validators.required, Validators.minLength, Validators.maxLength]],
      document: ['', Validators.required],
      phonenumber: ['', Validators.required],
      email: ['', [Validators.required, Validators.pattern(/^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/)]],
    });
  }

  studentSubmit() {
    console.log(this.studentForm.value);
  }

  selectedRowFromTable(student: Student) {
    this.selectedStudent = student;
    this.studentForm.patchValue(student);
  }

  openModal(template: TemplateRef<any>) {
    this.modalReference = this.modalService.show(template, this.modalConfig);
  }

  backToList() {
    this.selectedStudent = null;
  }
}
