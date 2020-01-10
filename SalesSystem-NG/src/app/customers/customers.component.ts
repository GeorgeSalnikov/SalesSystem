import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {

  customers = [];
	constructor(private apiService: ApiService) { }

	ngOnInit() {
		this.apiService.get().subscribe((data: any[])=>{  
			console.log(data);  
			this.customers = data;  
		})  
	}

}
