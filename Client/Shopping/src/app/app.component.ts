import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Shopping';
  results = [];
  cart = [];
  addToCart = function (item){
    this.cart.push(item);
    alert(item.name + ' was added to your cart for N$' + item.price);
  }

  constructor(private http: HttpClient){

  }

  ngOnInit() : void {
    interface Product{
      name: string;
      category: string;
      price: number;
    }
    this.http.get<Product>('https://localhost:44328/api/products').subscribe(data => {
      // this.results = data;
      for (let i in data) this.results.push(data[i]);
    });
  }
}
