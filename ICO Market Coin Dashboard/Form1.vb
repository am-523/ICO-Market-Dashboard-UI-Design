Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chart()
        subchart()
    End Sub

    Private Sub chart()
        CartesianChart1.Series = New SeriesCollection From {
             New LineSeries With {
                 .Values = New ChartValues(Of ObservablePoint) From {
                       New ObservablePoint(0, 4),
                       New ObservablePoint(1, 10),
                       New ObservablePoint(2, 20),
                       New ObservablePoint(3, 30),
                       New ObservablePoint(4, 42),
                       New ObservablePoint(5, 55),
                       New ObservablePoint(6, 67),
                       New ObservablePoint(7, 69),
                       New ObservablePoint(8, 70),
                       New ObservablePoint(9, 81),
                       New ObservablePoint(10, 92),
                       New ObservablePoint(11, 93),
                       New ObservablePoint(12, 24),
                       New ObservablePoint(13, 25),
                       New ObservablePoint(14, 50),
                       New ObservablePoint(15, 59),
                       New ObservablePoint(16, 50),
                       New ObservablePoint(17, 71),
                       New ObservablePoint(18, 72),
                       New ObservablePoint(19, 85),
                       New ObservablePoint(20, 98)
                   },
                   .PointGeometrySize = 15
                 }
                 }

    End Sub

    Private Sub subchart()
        CartesianChart2.Series = New SeriesCollection From {
             New ColumnSeries With {
                 .Title = "2015",
                 .Values = New ChartValues(Of Double) From {
                     10,
                     50,
                     39,
                     50,
                     40,
                     60,
                     10,
                     35,
                     70,
                     40,
                     60,
                     10,
                     35
                 }
             }
         }
        CartesianChart2.Series.Add(New ColumnSeries With {
            .Title = "2016",
            .Values = New ChartValues(Of Double) From {
                11,
                56,
                42,
                  40,
                        60,
                        10,
                        35,
                        70,
                        40,
                        60,
                        10,
                        35
            }
        })
        CartesianChart2.Series(1).Values.Add(48.0R)
        CartesianChart2.AxisX.Add(New Axis With {
            .Title = "Market",
            .Labels = {"Jan", "Feb", "Mar", "Apr", "Mey", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Des"}
        })
        CartesianChart2.AxisY.Add(New Axis With {
            .Title = "Coins",
            .LabelFormatter = Function(value) value.ToString("N")
        })
    End Sub
End Class
