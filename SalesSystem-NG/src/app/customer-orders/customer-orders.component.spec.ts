import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customer-orders.component.html',
  styleUrls: ['./customer-orders.component.css']
})
export class CustomerOrdersComponent implements OnInit {

  	customer = null;
    constructor(private apiService: ApiService, private activatedRoute: ActivatedRoute) { }

	ngOnInit() {
		this.apiService.getCustomerDetails(this.activatedRoute.snapshot.params.id).subscribe((data: any[])=>{  
			console.log(data);  
			this.customer = data;  
		})  
	}

	deleteOrder(id: any) {
		this.apiService.deleteOrder(id);
		return true;
	}
}
