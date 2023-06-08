# FrameWork-Programming

Explanation of the application based on Clean Architecture:

1. What entities/models are involved in the application? 
We have to create model for User and Product table

2. Application use cases. Format: <Role type> can perform <a feature>
/

3. Controllers, Middleware, and additional libraries used and their 
respective functions.

Spatie package provide it's in-built middleware that way we can use it simply and that is display as bellow:
role
permission

We need to generate auth scaffolding in laravel 8

We need to install NPM

We require to add number of route for users module, products module and roles module.

We have add three controller for users module, products module and roles module so you can create three controller.

We need to create following files as like listed bellow: Theme Layout, Users Module, Roles Module, Product Module

we will create seeder for permissions, Right now we have fixed permission so we create using seeder as listed bellow, but if you can add more permission as you want:
    1.role-list
    2.role-create
    3.role-edit
    4.role-delete
    5.product-list
    6.product-create
    7.product-edit
    8.product-delete

4. DB, external interfaces: database table structure used.

User Table:
The User table could include columns such as:
name (Name): This column stores the name of the user or email (Email): This column contains the user's email address.
password (Password): This column stores the user's password.

Pictures:

![alex](scren/3.png)

![alex](scren/4.png)

![alex](scren/5.png)

![alex](scren/6.png)