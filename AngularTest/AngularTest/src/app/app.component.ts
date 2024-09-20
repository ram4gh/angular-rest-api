import { DataSource } from '@angular/cdk/collections';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';

import { MatTableModule } from '@angular/material/table';


@Component({
  selector: 'app-root',
  styleUrl: './app.component.css',
  templateUrl: './app.component.html',
  standalone: true,
  imports: [MatTableModule],
})


export class AppComponent {
  public getJsonValue: any;
  public postJsonValue: any;
  public displayedColumns: string[] = ['id', 'name', 'address'];
  public dataSource: any = [];

  constructor(private http: HttpClient) { }

  //method called when add button is pressed to send the data to the DB and then refresh the data grid
  public AddAddress() {
    const header = new HttpHeaders({
      contentType: 'application/json'
    })
    let body = {
      id: 0,
      name: (<HTMLInputElement>document.getElementById("Name_box")).value,
      address: (<HTMLInputElement>document.getElementById("Address_box")).value
    };

    this.http.post('https://localhost:7223/api/Address/CreateEdit', body, { headers: header }).subscribe((data) => {
      this.postJsonValue = data;
    });

    //need to run twice to get the list to properly update as the list gets bigger.
    this.getMethod();
    this.getMethod();
  }

  //method calls the get all function from the API and returns all values in the DB
  public getMethod() {
    this.http.get('https://localhost:7223/api/Address/GetAll').subscribe((data) => {
      this.getJsonValue = data;
      this.dataSource = this.getJsonValue.value;
    });
  }
}
