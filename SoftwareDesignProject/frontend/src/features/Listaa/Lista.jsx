import "./ListaStyle.css";
import fakeData from "./MOCK_DATA.json";
import * as React from "react";
import { useTable } from "react-table";

export default function Table(){
    const data = React.useMemo(() => fakeData, []);
    const columns = React.useMemo(
      () => [
        {
          Header: "#",
          accessor: "id",
        },
        {
          Header: "Emri",
          accessor: "first_name",
        },
        {
          Header: "Mbiemri",
          accessor: "last_name",
        },
        {
          Header: "Fakulteti",
          accessor: "email",
        },
        {
          Header: "Gjinia",
          accessor: "gender",
        },
        {
          Header: "Komuna",
          accessor: "university",
        },
        {
            Header: "Pike qyteti",
            accessor: "pikeC",
        },
        {
            Header: "Pike distanca",
            accessor: "pikeD",
        },
        {
            Header: "Nota Mesatare",
            accessor: "pikeN",
        },
        {
            Header: "Totali",
            accessor: "total",
        },
      ],
      []
    );
  
    const { getTableProps, getTableBodyProps, headerGroups, rows, prepareRow } =
      useTable({ columns, data });
      return (
        <div className="App">
          <div className="container">
            <br></br>
            <br></br>
            <br></br>
            <br></br>
            <br></br>
            
            <table {...getTableProps()}>
              <thead>
                {headerGroups.map((headerGroup) => (
                  <tr {...headerGroup.getHeaderGroupProps()}>
                    {headerGroup.headers.map((column) => (
                      <th {...column.getHeaderProps()}>
                        {column.render("Header")}
                      </th>
                    ))}
                  </tr>
                ))}
              </thead>
              <tbody {...getTableBodyProps()}>
                {rows.map((row) => {
                  prepareRow(row);
                  return (
                    <tr {...row.getRowProps()}>
                      {row.cells.map((cell) => (
                        <td {...cell.getCellProps()}> {cell.render("Cell")} </td>
                      ))}
                    </tr>
                  );
                })}
              </tbody>
            </table>
          </div>
        </div>
      );
}

