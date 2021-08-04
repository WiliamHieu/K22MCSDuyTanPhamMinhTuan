using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 9999.
                Int32 port = 9999;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.

                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");


                    Socket handler = server.AcceptSocket();

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        //// Translate data bytes to a ASCII string.
                        //data = Encoding.ASCII.GetString(bytes, 0, i);
                        //Console.WriteLine("Received: {0}", data);

                        //// Process the data sent by the client.
                        //data = data.ToUpper();

                        //byte[] msg = Encoding.ASCII.GetBytes(data);

                        //// Send back a response.
                        //stream.Write(msg, 0, msg.Length);
                        //Console.WriteLine("Sent: {0}", data);

                        TCPHeader tcpHeader = new TCPHeader(bytes, bytes.Length);

                        Console.WriteLine("SourcePort: {0}", tcpHeader.SourcePort);
                        Console.WriteLine("DestinationPort: {0}", tcpHeader.DestinationPort);
                        Console.WriteLine("SequenceNumber: {0}", tcpHeader.SequenceNumber);
                        Console.WriteLine("SourcePort: {0}", tcpHeader.SourcePort);
                        Console.WriteLine("SourcePort: {0}", tcpHeader.SourcePort);
                        Console.WriteLine("SourcePort: {0}", tcpHeader.SourcePort);

                        if (tcpHeader.AcknowledgementNumber != "")
                            Console.WriteLine("Acknowledgement Number: {0}", tcpHeader.AcknowledgementNumber);

                        Console.WriteLine("HeaderLength: {0}", tcpHeader.HeaderLength);
                        Console.WriteLine("Flags: {0}", tcpHeader.Flags);
                        Console.WriteLine("Window Size: {0}", tcpHeader.WindowSize);
                        Console.WriteLine("Checksum: {0}", tcpHeader.Checksum);

                        if (tcpHeader.UrgentPointer != "")
                            Console.WriteLine("UrgentPointer: {0}", tcpHeader.UrgentPointer);
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
    }
}
