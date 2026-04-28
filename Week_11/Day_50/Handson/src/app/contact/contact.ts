import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';   

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [CommonModule, FormsModule],   
  templateUrl: 'contact.html',
  styleUrls: ['contact.css']
})
export class ContactComponent {

  searchText: string = '';

  contacts = [
    { name: 'bhavana', email: 'bhavana@gmail.com', phone: '9876543210', status: true },
    { name: 'rajesh', email: 'rajesh@gmail.com', phone: '9123456780', status: false },
    { name: 'sita', email: 'sita@gmail.com', phone: '9012345678', status: true },
    { name: 'ram', email: 'ram@gmail.com', phone: '9988776655', status: false },
    { name: 'john', email: 'john@gmail.com', phone: '8899776655', status: true },
    { name: 'david', email: 'david@gmail.com', phone: '7766554433', status: true },
    { name: 'anita', email: 'anita@gmail.com', phone: '6655443322', status: false },
    { name: 'kiran', email: 'kiran@gmail.com', phone: '5544332211', status: true },
    { name: 'meena', email: 'meena@gmail.com', phone: '4433221100', status: false },
    { name: 'arjun', email: 'arjun@gmail.com', phone: '3322110099', status: true }
  ];

  toggleStatus(contact: any) {
    contact.status = !contact.status;
  }
}