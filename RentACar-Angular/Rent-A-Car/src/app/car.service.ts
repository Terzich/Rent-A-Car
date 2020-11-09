import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Car } from './car-model';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  apiUrl="https://localhost:44308/api/car/get";
  apiUrlSave="https://localhost:44308/api/car/add";


  options=new HttpHeaders().set('content-type', 'application/json')
  .set('Access-Control-Allow-Origin', '*');

  

  constructor(private http:HttpClient) { }

  getCarsFormServer():Observable<Car[]>
  {
    return this.http.get<Car[]>(this.apiUrl,{'headers':this.options});

  }

  saveCar(car:Car):Observable<number>
  {
    return this.http.post<number>(this.apiUrlSave,car,{'headers':this.options});
  }


}


