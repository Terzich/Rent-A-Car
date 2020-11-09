import { Input } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { Car } from '../car-model';

@Component({
  selector: 'app-car-details',
  templateUrl: './car-details.component.html',
  styleUrls: ['./car-details.component.scss']
})
export class CarDetailsComponent implements OnInit {

@Input() car:Car;

  constructor() { }

  ngOnInit(): void {
  }

}
