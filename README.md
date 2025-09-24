# Personal Assistant Secretary
[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120?style&logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/LLarean/secretary-eo/blob/main/LICENSE)
[![Project Status](https://img.shields.io/badge/Status-Prototype-orange)](https://github.com/LLarean/secretary-eo)
[![GitHub Last Commit](https://img.shields.io/github/last-commit/LLarean/kings-bounty)](https://github.com/llarean/secretary-eo)

> A personal secretary application that provides daily briefings with important information at startup

## Features

- **Greeting depending on the time of day**
- **Current date and time**
- **Weather forecast** (OpenWeatherMap API)
- **Unread email count** (IMAP/Gmail API)
- **Latest news** from RSS feeds
- **Daily summary dashboard**

## Getting Started

### Prerequisites

- .NET 8.0 or higher
- JetBrains Rider
- API keys for external services

### Installation

```bash
# Clone the repository
git clone https://github.com/llarean/secretary-eo.git
cd secretary-eo

# Restore dependencies
dotnet restore

# Build the project
dotnet build
```

### Configuration

~~1. Copy `appsettings.example.json` to `appsettings.json`~~
~~2. Fill in the required API keys:~~

```json

```

### Running

```bash
dotnet run
```
~~

## Sample Output

```
Welcome! Today is Wednesday, September 24, 2025

Weather in Moscow:
   Temperature: +18°C
   Humidity: 65%
   Wind: 3 m/s

Email:
   Unread messages: 5

Latest News:
   • First news headline...
   • Second news headline...
   • Third news headline...
```

## 🔧 Configuration

~~The application supports configuration through `appsettings.json`:~~

## Built With

- **Framework**: .NET 8.0
- **HTTP Client**: HttpClient
- **JSON**: System.Text.Json
- **RSS**: SyndicationFeed
- **Email**: MailKit
- **Console UI**: Spectre.Console (optional)

## Dependencies

```xml

```

## Contributing

I would be happy to welcome any contribution! Please:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## Roadmap

- [ ] The welcome module
- [ ] The weather module
- [ ] The news module
- [ ] The email module
- [ ] Configurations

- [ ] Notification support
- [ ] Calendar integration
- [ ] System tray support
- [ ] Windows startup integration

- [ ] GUI interface (WPF/Avalonia)
- [ ] Custom themes

## License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/LLarean/secretary-eo/blob/main/LICENSE) file for details.

## Connection

- GitHub: [@LLarean](https://github.com/LLarean)
- Email: llarean@ya.ru

---

<div align="center">
  
⭐ If this project helped you, please consider giving it a star!

</div>
