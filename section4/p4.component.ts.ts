import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-p4',
  templateUrl: './p4.component.html',
  styleUrls: ['./p4.component.css']
})
export class P4Component implements OnInit {
  movieslist :any[]= [
    {name :"Love Mocktail"},
    {name:"June"},
    {name :"RRR"},
    {name :"Akanda"},
    {name :"Sita Ramamam"}
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
