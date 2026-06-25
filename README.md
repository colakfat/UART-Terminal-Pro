# UART Terminal Pro

[Türkçe](README.md) • **English**

A modern UART communication application built for embedded system development and test automation.

> C# • .NET Framework 4.8 • Windows Forms

---

## ✨ Features

- **Serial connection management** — auto-detects and sorts COM ports; connect/disconnect with one click.
- **Full configuration** — Baud rate, Data Bits, Parity, Stop Bits selection.
- **Colored terminal** — incoming `[RX]` in green, outgoing `[TX]` in blue, `[WAIT]` in gold.
- **Timestamps** — optional `HH:mm:ss.fff` time prefix on each line.
- **HEX / ASCII mode** — view incoming data as readable text or hexadecimal.
- **Line-based command sending** — type multiple lines and send them all in sequence.
- **`WAIT` command** — insert millisecond delays between commands (simple scripting).
- **HEX sending** — send a command as a hexadecimal byte array.
- **Periodic sending** — automatically resend commands at a defined interval (ms).
- **Live counters** — RX message, TX message and error counts.
- **Auto scroll** — terminal follows new data to the bottom (toggleable).
- **Log saving** — export terminal content to `.txt` / `.log` in UTF-8.
- **Dark theme** — eye-friendly navy/blue interface.

---

## 🖼️ Screenshot

![UART Terminal Pro](UART_TerminalPro.png)

---

## 🧩 Requirements

- **Windows** (7/10/11)
- **.NET Framework 4.8** runtime
- To build: **Visual Studio 2019/2022** (or .NET Framework 4.8 build tools with MSBuild)

---

## 🚀 Installation & Running

### Run prebuilt
1. Build the project or download the shared release.
2. Run **`UARTTerminalPro.exe`** from the `bin\Debug\` (or `bin\Release\`) folder.

### Build from source
```bash
# With Visual Studio
Open UARTTerminalPro.sln → Build → Run (F5)

# Or with MSBuild
msbuild UARTTerminalPro.csproj /p:Configuration=Release
```

---

## 📖 Usage

### 1. Connection
1. Plug the device into your computer; the app lists COM ports automatically on startup.
2. Select **COM Port**, **Baud rate**, **Data Bits**, **Parity**, **Stop Bits**.
   - Defaults: `115200`, `8`, `None`, `One`.
3. Click **Bağlan** (Connect). The status indicator turns green **● Bağlı** (Connected).
   - Click again to disconnect (**● Bağlı Değil** / Not Connected, red).

### 2. Sending Data
- Type your command in the **VERİ GÖNDER** (Send Data) box and press **➤ GÖNDER** (Send).
- If you enter multiple lines, each line is sent **sequentially** as a separate command.
- When **HEX Gönder** (Send HEX) is checked, the command is interpreted as hexadecimal (e.g. `48656C6C6F`).
  - Format: a hex string with no spaces and an even number of characters.

### 3. Delays with `WAIT`
To insert a wait between command lines:
```
WAIT 500
```
This line waits **500 ms** before sending the next command. It appears in the terminal as `[WAIT] 500 ms`.

Example send sequence:
```
AT
WAIT 1000
AT+VERSION
WAIT 500
AT+RESET
```

### 4. Periodic Sending
1. Enter the interval in the **Periyot (ms)** (Period) field (adjustable with the arrows).
2. Check **Periyodik Gönder** (Periodic Send) → the command(s) in the box are sent automatically at that interval.
3. Unchecking it stops the sending.

### 5. Terminal Options
| Option | Description |
|--------|-------------|
| **Timestamp** | Adds a time prefix to each line. |
| **Auto Scroll** | Automatically scrolls to the bottom as new data arrives. |
| **HEX Mode** | Displays incoming data as hexadecimal. |

### 6. Other Buttons
| Button | Function |
|--------|----------|
| **TERMİNALİ TEMİZLE** (Clear Terminal) | Clears the terminal and resets counters. |
| **LOG KAYDET** (Save Log) | Saves terminal content to a `.txt` / `.log` file. |
| **YAZIYI KOPYALA** (Copy Text) | Copy terminal text (present in the interface). |

---

## 🗂️ Project Structure

```
UARTTerminalPro/
├── Program.cs              # Application entry point
├── Form1.cs                # Main window logic (serial port, sending, logging, etc.)
├── Form1.Designer.cs       # UI design (controls, layout, colors)
├── Form1.resx              # Form resources
├── App.config              # .NET Framework runtime configuration
├── Uart.ico                # Application icon
├── Properties/             # AssemblyInfo, Settings, Resources
└── UARTTerminalPro.sln     # Visual Studio solution file
```

---

## 🔧 Technical Details

- **Language / Framework:** C#, .NET Framework 4.8, Windows Forms (WinExe).
- **Serial communication:** `System.IO.Ports.SerialPort`.
- **Data reception:** the `DataReceived` event fires on a background thread; the UI is updated thread-safely via `Invoke`.
- **Sending:** line by line with `async/await`; the `WAIT` command uses `Task.Delay`.
- **Periodic sending:** via `System.Windows.Forms.Timer`.
- **Log format:** UTF-8, default file name `UART_Log_yyyyMMdd_HHmmss.txt`.

---

## 📝 Notes

- The **error counter** is shown in the UI; it can be wired to error-handling logic in future versions.
- Connection errors are caught silently; the app does not crash on invalid port/parameter selection.
- HEX sending expects a valid hex string (no spaces, even length).

---

## 📦 Version

Initial release — core UART terminal features completed.

---

## 📄 License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

---

> This application is a practical helper for embedded systems / microcontroller development and
> serial port testing. Feedback and contributions are welcome.
