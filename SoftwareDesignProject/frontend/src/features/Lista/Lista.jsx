import "./ListaStyle.css";
import fakeData from "./MOCK_DATA.json";
import * as React from "react";
import { useTable } from "react-table";
import Footer from "../../components/footer";

export default function Table() {
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

  const {
    getTableProps,
    getTableBodyProps,
    headerGroups,
    rows,
    prepareRow,
  } = useTable({ columns, data });
  return (
    <>
    <h2 className= "left-h2">Lista e te pranuarve</h2>
    <div className="table-containerT">
      <table className="tableT" {...getTableProps()}>
        <thead className="table-headT">
          {headerGroups.map((headerGroup) => (
            <tr {...headerGroup.getHeaderGroupProps()}>
              {headerGroup.headers.map((column) => (
                <th className="table-header-cellT" {...column.getHeaderProps()}>
                  {column.render("Header")}
                </th>
              ))}
            </tr>
          ))}
        </thead>
        <tbody className="table-bodyT" {...getTableBodyProps()}>
          {rows.map((row) => {
            prepareRow(row);
            return (
              <tr className="table-rowT" {...row.getRowProps()}>
                {row.cells.map((cell) => (
                  <td className="table-cellT" {...cell.getCellProps()}>
                    {cell.render("Cell")}
                  </td>
                ))}
              </tr>
            );
          })}
        </tbody>
      </table>
    </div>
   
    </>
  );
}
