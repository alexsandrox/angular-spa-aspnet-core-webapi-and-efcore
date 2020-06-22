import { Student } from './../models/Student';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

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
    { id: 1, firstname: 'Donald', lastname: 'Trump', phonenumber: '1111111111', document: '123.456.789-10', email: 'donald@smartschool.com'},
    { id: 2, firstname: 'Mickey', lastname: 'Mouse', phonenumber: '2222222222', document: '321.654.987-11', email: 'mickey@smartschool.com'},
    { id: 3, firstname: 'Pateta', lastname: 'patetâncio', phonenumber: '3333333333', document: '987.654.432-12', email: 'pateta@smartschool.com'},
    { id: 4, firstname: 'Minie', lastname: 'Mouse', phonenumber: '4444444444', document: '654.321.987-13', email: 'minie@smartschool.com'},
    { id: 5, firstname: 'Patinhas', lastname: 'Bilio', phonenumber: '5555555555', document: '123.987.456-14', email: 'patinhas@smartschool.com'},
    { id: 6, firstname: 'Pernalonga', lastname: 'Champs', phonenumber: '6666666666', document: '879.543.672-15', email: 'pernalonga@smartschool.com'},
    { id: 7, firstname: 'Gaginho', lastname: 'Pig', phonenumber: '7777777777', document: '692.390.012-16', email: 'gaginhopig@smartschool.com'},
  ];

  constructor(private formBuilder: FormBuilder,
              private modalService: BsModalService) {
    this.createForm();
  }

  ngOnInit() {
  }

  createForm() {
    this.studentForm = this.formBuilder.group({
      firstname: ['', Validators.required],
      lastname: ['', Validators.required],
      document: ['', Validators.required],
      phonenumber: ['', Validators.required],
      email: ['', Validators.required],
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
