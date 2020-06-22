import { Teacher } from './../models/Teacher';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-teachers',
  templateUrl: './teachers.component.html',
  styleUrls: ['./teachers.component.css']
})
export class TeachersComponent implements OnInit {

  public title = 'Lista de Professores';

  public teachers = [
    { id: 1, firstname: 'Girafales', lastname: 'Morales', subject: 'História'},
    { id: 2, firstname: 'Pardal', lastname: 'Voador', subject: 'Geografia'},
    { id: 3, firstname: 'Raimundo', lastname: 'Nonato', subject: 'Português'},
    { id: 4, firstname: 'Jão', lastname: 'Neves', subject: 'Matemática'},
  ];

  public selectedTeacher: Teacher;

  selectedRowFromTable(teacher: Teacher){
    this.selectedTeacher = teacher;
  }

  backToList(){
    this.selectedTeacher = null;
  }

  constructor() { }

  ngOnInit() {
  }

}
