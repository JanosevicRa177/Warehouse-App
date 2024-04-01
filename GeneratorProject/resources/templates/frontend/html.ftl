<table>
  <thead>
    <tr>
    <#if '${class.name}' == 'User' || '${class.name}' == 'Worker' || '${class.name}' == 'Manager'>
      <th>Email</th>
      <th>First name</th>
      <th>Contact</th>
    </#if>
    <#if '${class.name}' == 'Warehouse'>
      <th>Name</th>
      <th>Size</th>
    </#if>
      <th></th>
    </tr>
  </thead>
  <tbody>
    <tr *ngFor="let item of data">
    <#if '${class.name}' == 'User' || '${class.name}' == 'Worker' || '${class.name}' == 'Manager'>
  	  <td>{{ item.email }}</td>
  	  <td>{{ item.firstName }}</td>
  	  <td>{{ item.contact }}</td>
    </#if>
    <#if '${class.name}' == 'Warehouse'>
      <th>{{ item.name }}</th>
      <th>{{ item.size }}</th>
    </#if>
      <td><button class="delete-btn" (click)="delete(item.id)">Delete</button></td>
    </tr>
  </tbody>
</table>