# CheckIn Processing Microservices

A mini **event-driven microservices** project built with **.NET 8**, **RabbitMQ**, **MassTransit**, **Docker**, and **SQLite**.

This project simulates an employee check-in system where one action can trigger multiple independent services through asynchronous messaging.

---

# 🚀 Tech Stack

* .NET 8
* ASP.NET Core Web API
* RabbitMQ
* MassTransit
* Docker & Docker Compose
* SQLite
* Swagger

---

# 🏗️ Architecture

```text
Client
  ↓
AttendanceService
  ↓ Publish Event: EmployeeCheckedIn
RabbitMQ
 ↙                      ↘
NotificationService     ReportingService
```

---

# 📦 Services

## 1. AttendanceService

Responsible for:

* Employee check-in API
* Save attendance record
* Publish `EmployeeCheckedIn` event

## 2. NotificationService

Responsible for:

* Consume check-in event
* Simulate sending notification/email
* Save notification log

## 3. ReportingService

Responsible for:

* Consume check-in event
* Save reporting/statistics data

---

# 📁 Project Structure

```text
src/
 ├── AttendanceService/
 ├── NotificationService/
 ├── ReportingService/
 └── Shared.Contracts/
```

---

# ⚙️ Features

* Event-driven communication
* Loose coupling between services
* Multiple consumers from one event
* Independent databases per service
* Containerized development environment

---

# 🐳 Run with Docker

```bash
docker compose up --build
```

---

# 🌐 Endpoints

## Attendance Swagger

```text
http://localhost:5001/swagger
```

## RabbitMQ Dashboard

```text
http://localhost:15672
```

Default credentials:

```text
guest / guest
```

---

# 🧪 Sample Request

## POST `/api/attendance/checkin`

```json
{
  "employeeId": "EMP001",
  "employeeName": "Trieu"
}
```

---

# ✅ Expected Flow

1. Attendance record saved
2. Event published to RabbitMQ
3. NotificationService consumes event
4. ReportingService consumes event

---

# 📚 What I Learned

* Microservices fundamentals
* Message Broker architecture
* Publish / Subscribe pattern
* Asynchronous communication
* Service isolation
* Dockerized distributed systems

---

# 💼 Resume Highlight

Built event-driven microservices using .NET 8, RabbitMQ, Docker, and SQLite with asynchronous communication and multi-service architecture.

---

# 🔥 Future Improvements

* JWT Authentication
* API Gateway (YARP / Ocelot)
* SQL Server
* Retry / Dead Letter Queue
* Centralized Logging
* React Admin Dashboard
* CI/CD Pipeline

---

# 👨‍💻 Author

Developed as a hands-on learning project for modern backend architecture.
