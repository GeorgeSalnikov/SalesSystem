import { ApiService } from '../api.service';
import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-customer-orders',
  templateUrl: './customer-orders.component.html',
  styleUrls: ['./customer-orders.component.css']
})
export class CustomerOrdersComponent implements OnInit {
  customer = null;
  
  constructor(private apiService: ApiService, private activatedRoute: ActivatedRoute) { }
  //constructor(private router: Router) { }

	ngOnInit() {
		  this.apiService.getCustomerDetails(this.activatedRoute.snapshot.params.id).subscribe((data: any)=>{  
			console.log(data);  
			this.customer = data;  
		})  
  }
  public deleteOrder(orderId: any){  
    this.apiService.deleteOrder(orderId).subscribe((data: any)=>{  
			console.log(data); 
			this.customer = data;  
		})   
  }
}
