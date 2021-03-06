import { Teacher } from './../models/Teacher';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-teachers',
  templateUrl: './teachers.component.html',
  styleUrls: ['./teachers.component.css']
})
export class TeachersComponent implements OnInit {

  public teacherForm: FormGroup;
  public title = 'Lista de Professores';
  public selectedTeacher: Teacher;
  public modalReference: BsModalRef;
  public modalConfig = {
    animated: true
  };

  public teachers = [
    { id: "1", firstname: 'Girafales', lastname: 'Gonzales'},
    { id: "2", firstname: 'Pardal', lastname: 'Voador'},
    { id: "3", firstname: 'Raimundo', lastname: 'Nonato'},
    { id: "4", firstname: 'Alexsandro', lastname: 'Andrade'},
    { id: "5", firstname: 'Gladys', lastname: 'Moreno'},
  ];

  constructor(private formBuilder: FormBuilder,
              private modalService: BsModalService) {
    this.createForm();
  }

  ngOnInit() {
  }

  createForm() {
    this.teacherForm = this.formBuilder.group({
      firstname: ['', Validators.required],
      lastname: ['', Validators.required],
      subject: ['', Validators.required]
    });
  }

  teacherSubmit() {
    console.log(this.teacherForm.value);
  }

  selectedRowFromTable(teacher: Teacher){
    this.selectedTeacher = teacher;
    this.teacherForm.patchValue(teacher);
  }

  openModal(template: TemplateRef<any>) {
    this.modalReference = this.modalService.show(template, this.modalConfig);
  }

  backToList(){
    this.selectedTeacher = null;
  }
}
